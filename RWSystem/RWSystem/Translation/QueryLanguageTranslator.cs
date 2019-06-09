using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWSystem.Utils;

namespace RWSystem.Translation
{
    class QueryLanguageTranslator
    {
        Dictionary<QueryType, BaseTranslator> translators = new Dictionary<QueryType, BaseTranslator>()
        {
            { QueryType.Necessary,
                new NecessaryTranslator() },
            { QueryType.Possibly,
                new PossiblyTranslator() },
            { QueryType.NecessaryWhen,
                new NecessaryWhenTranslator() },
            { QueryType.PossiblyWhen,
                new PossiblyWhenTranslator() },
            { QueryType.TypicallyWhen,
                new TypicallyWhenTranslator() }
        };

        Dictionary<QueryType, Token[]> characteristicTokens = new Dictionary<QueryType, Token[]>()
        {
            { QueryType.Necessary,
                new Token[] { Token.Necessary} },
            { QueryType.Possibly,
                new Token[] { Token.Possibly} },
            { QueryType.NecessaryWhen,
                new Token[] { Token.Necessary, Token.At, Token.When} },
            { QueryType.PossiblyWhen,
                new Token[] { Token.Possibly, Token.At, Token.When} },
            { QueryType.TypicallyWhen,
                new Token[] { Token.Typically, Token.At, Token.When} }
        };

        public string Translate(string query)
        {
            string[] tokens = query.Split(' ').Where(s => !s.IsNullOrWhiteSpace()).ToArray();
            QueryType? queryType = GetQueryType(tokens);

            if (!queryType.HasValue)
                throw new Exception("Invalid statement");

            return translators[queryType.Value].Translate(tokens);
        }

        QueryType? GetQueryType(string[] tokens)
        {
            foreach (QueryType statemenType in Enum.GetValues(typeof(QueryType)))
            {
                if (characteristicTokens[statemenType].Aggregate(true, (acc, token) => acc && tokens.Contains(token.Value)))
                    return statemenType;
            }
            return null;
        }

    }
}

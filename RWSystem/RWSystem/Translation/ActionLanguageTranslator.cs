using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class ActionLanguageTranslator
    {
        Dictionary<StatementType, BaseTranslator> translators = new Dictionary<StatementType, BaseTranslator>()
        {
            { StatementType.Causes,
                new CausesStatementTranslator() },
            { StatementType.TypicallyCauses,
                new TypicallyCausesStatementTranslator() },
            { StatementType.Invokes,
                new InvokesStatementTranslator() },
            { StatementType.Triggers,
                new TriggersStatementTranslator() },
            { StatementType.Releases,
                new ReleasesStatementTranslator() },
            { StatementType.DisableBetween,
                new DisbaleBetweenStatementTranslator() },
            { StatementType.DisableWhen,
                new DisableWhenStatementTranslator() }
        };

        Dictionary<StatementType, Token[]> characteristicTokens = new Dictionary<StatementType, Token[]>()
        {
            { StatementType.Causes,
                new Token[] { Token.Causes} },
            { StatementType.TypicallyCauses,
                new Token[] { Token.Typically, Token.Causes } },
            { StatementType.Invokes,
                new Token[] { Token.Invokes } },
            { StatementType.Triggers,
                new Token[] { Token.Triggers } },
            { StatementType.Releases,
                new Token[] { Token.Releases } },
            { StatementType.DisableBetween,
                new Token[] { Token.Disable, Token.Between } },
            { StatementType.DisableWhen,
                new Token[] { Token.Disable, Token.When } }
        };

        public string Translate(string story)
        {
            string[] statements = story.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            return string.Join("\n", statements.Select(s => TranslateStatement(s)));
        }

        string TranslateStatement(string statement)
        {
            string[] tokens = statement.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(s => s.Trim(','))
                                       .ToArray();
            StatementType? statementType = GetStatementType(tokens);

            if (!statementType.HasValue)
                throw new Exception("Invalid statement");

            return translators[statementType.Value].Translate(tokens);
        }

        StatementType? GetStatementType(string[] tokens)
        {
            foreach(StatementType statemenType in Enum.GetValues(typeof(StatementType)))
            {
                if (characteristicTokens[statemenType].Aggregate(true, (acc, token) => acc && tokens.Contains(token.Value)))
                    return statemenType;
            }
            return null;
        }
    }
}

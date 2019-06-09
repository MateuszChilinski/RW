using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Tests")]

namespace RWSystem.Translation
{
    abstract class BaseTranslator
    {
        public abstract string Translate(string[] tokens);

        protected string TranslateFormula(string[] tokens)
        {
            int i = 0;
            string result = "[";
            List<string> tokensSublist = new List<string>();
            string parsedAlternative;
            int alternativesCount = 0;

            while (i < tokens.Length)
            {
                switch(tokens[i])
                {
                    case ",":
                        parsedAlternative = TranslateAlternative(tokensSublist.ToArray());
                        result += (alternativesCount > 0 ? ", " + parsedAlternative : parsedAlternative);
                        alternativesCount++;
                        tokensSublist.Clear();
                        i++;
                        break;
                    default:
                        tokensSublist.Add(tokens[i]);
                        i++;
                        break;
                }
            }
            parsedAlternative = TranslateAlternative(tokensSublist.ToArray());
            result += (alternativesCount > 0 ? ", " + parsedAlternative : parsedAlternative);
            result += "]";

            return result;
        }

        string TranslateAlternative(string[] tokens)
        {
            int i = 0;
            string result = "[";
            string literal = "";
            int literalsCount = 0;
            string parsed_literal;

            while (i < tokens.Length)
            {
                switch(tokens[i])
                {
                    case "|":
                        parsed_literal = TranslateLiteral(literal);
                        result += (literalsCount > 0 ? ", " + parsed_literal : parsed_literal);
                        literalsCount++;
                        i++;
                        break;
                    case "(":
                        i++;
                        break;
                    case ")":
                        i++;
                        break;
                    default:
                        literal = tokens[i];
                        i++;
                        break;
                }
            }
            parsed_literal = TranslateLiteral(literal);
            result += (literalsCount > 0 ? ", " + parsed_literal : parsed_literal);
            result += "]";

            return result;
        }

        string TranslateLiteral(string literal)
        {
            if (literal.StartsWith("~") || literal.StartsWith("¬"))
                return "not_" + literal.Substring(1);
            return literal;
        }
    }
}

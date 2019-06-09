using RWSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class TypicallyCausesStatementTranslator : BaseTranslator
    {
        //Translates 'A typically causes <result> if <condition>'
        //into 'typically_causes(A, <result>, <condition>).'
        public override string Translate(string[] tokens)
        {
            string action = tokens[0].FirstToLower();
            int indexOfIf = Array.IndexOf(tokens, Token.If.Value);
            int indexOfTypicallyCauses = Array.IndexOf(tokens, Token.Causes.Value);

            string condition = "[]";
            string result = "[]";

            if (indexOfIf > 2)
            {
                condition = TranslateFormula(tokens.SubArray(indexOfIf + 1, tokens.Length));
                result = TranslateFormula(tokens.SubArray(indexOfTypicallyCauses + 1, indexOfIf));
            }
            else
            {
                result = TranslateFormula(tokens.SubArray(indexOfTypicallyCauses + 1, tokens.Length));
            }

            return $"typically_causes({action}, {result}, {condition}).";
        }
    }
}

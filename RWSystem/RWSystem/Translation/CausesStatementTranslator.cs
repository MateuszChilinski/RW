using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWSystem.Utils;

namespace RWSystem.Translation
{
    class CausesStatementTranslator : BaseTranslator
    {
        //Translates 'A causes <result> if <condition>'
        //into 'causes(A, <result>, <condition>).'
        public override string Translate(string[] tokens)
        {
            string action = tokens[0];
            int indexOfIf = Array.IndexOf(tokens, Token.If.Value);
            int indexOfCauses =  Array.IndexOf(tokens, Token.Causes.Value);

            string condition;
            string result;
            if (indexOfIf > 0)
            {
                condition = TranslateFormula(tokens.SubArray(indexOfIf + 1, tokens.Length));
                result = TranslateFormula(tokens.SubArray(indexOfCauses + 1, indexOfIf));
            }
            else
            {
                condition = "1=1";
                result = TranslateFormula(tokens.SubArray(indexOfCauses + 1, tokens.Length));
            }           
            return $"causes({action}, {result}, {condition}).";
        }
    }
}

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
            string result = TranslateFormula(tokens.SubArray(2, indexOfIf));
            string condition = TranslateFormula(tokens.SubArray(indexOfIf, tokens.Length));

            return $"causes({action}, {result}, {condition}).";
        }
    }
}

using RWSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class ImpossibleStatementTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            string action = tokens[1].FirstToLower();
            int indexOfIf = Array.IndexOf(tokens, Token.If.Value);
            string condition;
            condition = TranslateFormula(tokens.SubArray(indexOfIf + 1, tokens.Length));

            return $"impossible({action}, {condition}).";
        }
    }
}

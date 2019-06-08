using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWSystem.Utils;

namespace RWSystem.Translation
{
    class TypicallyWhenTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            var indexOfAt = Array.IndexOf(tokens, Token.At.Value);
            var formula = TranslateFormula(tokens.SubArray(1, indexOfAt));
            var time = tokens[indexOfAt + 1];
            return $"typicallyCondition({formula}, {time})";
        }
    }
}

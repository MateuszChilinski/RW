using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWSystem.Utils;

namespace RWSystem.Translation
{
    class ObservationsTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            var openParenthis = tokens.FindAllIndexOf("(");
            var closeParenthis = tokens.FindAllIndexOf(")");

            var output = "obs([";

            for (int i = 0; i < openParenthis.Length; i++)
            {
                var observation = TranslateSingleTuple(tokens.SubArray(openParenthis[i] + 1, closeParenthis[i]));
                output += output.EndsWith("[") ? observation : (", " + observation);
            }

            return output + "]).";
        }

        private string TranslateSingleTuple(string[] tokens)
        {
            var indexOfSeparator = Array.IndexOf(tokens, ";");
            var state = TranslateFormula(tokens.SubArray(0, indexOfSeparator));
            var time = tokens[indexOfSeparator + 1];

            return $"({state}, {time})";
        }
    }
}

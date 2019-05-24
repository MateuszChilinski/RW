using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWSystem.Utils;

namespace RWSystem.Translation
{
    class NecessaryWhenTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            var secondWord = tokens[1];

            if (char.IsUpper(secondWord[0])) // akcja
            {
                var action = tokens[1].ToLower();
                var time = tokens[3];

                return $"necessaryAction({action}, {time})";
            }
            else
            {
                var indexOfAt = Array.IndexOf(tokens, Token.At.Value);
                var formula = TranslateFormula(tokens.SubArray(1, indexOfAt));
                var time = tokens[indexOfAt + 1];
                return $"necessaryFormula({formula}, {time})";
            }
        }
    }
}

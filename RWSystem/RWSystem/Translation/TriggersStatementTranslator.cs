using RWSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class TriggersStatementTranslator : BaseTranslator
    {
        //Translates '<condition> triggers A'
        //into 'triggers(<contidion>, A).'
        public override string Translate(string[] tokens)
        {
            int indexOfTriggers = Array.IndexOf(tokens, Token.Triggers.Value);
            string condition = TranslateFormula(tokens.SubArray(0, indexOfTriggers));

            string action = tokens[indexOfTriggers + 1];
        
            return $"triggers({condition}, {action}).";
        }
    }
}

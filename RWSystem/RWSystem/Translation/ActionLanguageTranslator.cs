using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class ActionLanguageTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            return base.TranslateFormula(tokens);
        }
    }
}

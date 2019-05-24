using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class NecessaryTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            return "necessary( sc ).";
        }
    }
}

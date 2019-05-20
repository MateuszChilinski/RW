using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    enum StatementType
    {
        Causes,
        TypicallyCauses,
        Invokes,
        Triggers,
        Releases,
        DisableBetween,
        DisableWhen
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Utils
{
    public static class StringExtensionMethods
    {
        public static string ToCamelCase(this string statement)
        {
            return Char.ToLowerInvariant(statement[0]) + statement.Substring(1);
        }
    }
}

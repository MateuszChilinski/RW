using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Utils
{
    public static class StringExtensionMethods
    {
        public static string FirstToLower(this string text)
        {
            return char.ToLower(text[0]).ToString() + text.Substring(1);
        }
    }
}

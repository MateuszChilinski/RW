using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    public class Token
    {
        private Token(string value) { Value = value }

        public string Value { get; set; }

        public static Token Causes { get { return new Token("causes"); } }
        public static Token Typically { get { return new Token("typically"); } }
        public static Token Invokes { get { return new Token("invokes"); } }
        public static Token Triggers { get { return new Token("triggers"); } }
        public static Token Releases { get { return new Token("releases"); } }
        public static Token Disabled { get { return new Token("disabled"); } }
        public static Token Between { get { return new Token("between"); } }
        public static Token When { get { return new Token("when"); } }
    }
}

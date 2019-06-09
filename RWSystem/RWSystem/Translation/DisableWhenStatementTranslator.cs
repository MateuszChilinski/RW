using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class DisableWhenStatementTranslator : BaseTranslator
    {
        //Translates 'Disable A when d'
        //into 'disable_when(A, d).'
        public override string Translate(string[] tokens)
        {
            int indexOfDisable = Array.IndexOf(tokens, Token.Disable.Value);
            string action = tokens[indexOfDisable + 1];
            int indexOfWhen = Array.IndexOf(tokens, Token.When.Value);
            if (!int.TryParse(tokens[indexOfWhen + 1], out int moment) || moment < 0)
                throw new Exception("Moment czasowy musi być liczbą całkowitą, dodatnią!");

            return $"disable_when({action}, {moment.ToString(CultureInfo.InvariantCulture)}).";
        }
    }
}

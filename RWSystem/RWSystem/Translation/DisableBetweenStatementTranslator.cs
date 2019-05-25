using RWSystem.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class DisbaleBetweenStatementTranslator : BaseTranslator
    {
        //Translates 'Disable A between start, end'
        //into 'disable_between(A, start, end).'
        public override string Translate(string[] tokens)
        {
            int disableIndex = Array.IndexOf(tokens, Token.Disable.Value);
            string action = tokens[disableIndex + 1];
            
            int betweenIndex = Array.IndexOf(tokens, Token.Between.Value);

            if(!int.TryParse(tokens[betweenIndex + 1], out int start) || start < 0)
                throw new Exception("Czas początkowy musi być liczbą całkowitą, nieujemną!");

            if (!int.TryParse(tokens[betweenIndex + 2], out int end) || end <= 0 || end <= start)
                throw new Exception("Czas końcowy musi być liczbą, dodatną oraz większą od start!");

            return $"disable_between({action}, {start.ToString(CultureInfo.InvariantCulture)}, {end.ToString(CultureInfo.InvariantCulture)}).";
        }
    }
}

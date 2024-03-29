﻿using RWSystem.Utils;
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
            string action = tokens[1].FirstToLower();

            if (!int.TryParse(tokens[3], out int moment) || moment < 0)
                throw new Exception("Moment czasowy musi być liczbą całkowitą, dodatnią!");

            return $"disable_between({action}, {moment.ToString(CultureInfo.InvariantCulture)}, {moment.ToString(CultureInfo.InvariantCulture)}).";
        }
    }
}

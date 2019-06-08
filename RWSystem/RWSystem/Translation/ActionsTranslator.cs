﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWSystem.Utils;

namespace RWSystem.Translation
{
    class ActionsTranslator : BaseTranslator
    {
        public override string Translate(string[] tokens)
        {
            var openParenthis = tokens.FindAllIndexOf("(");
            var closeParenthis = tokens.FindAllIndexOf(")");

            var output = "";

            for (int i = 0; i < openParenthis.Length; i++)
            {
                var tuple = tokens.SubArray(openParenthis[i] + 1, closeParenthis[i]);
                var action = tuple[0].ToLower();
                var time = tuple[tuple.Length - 1];
                output = output + $"action( {action}, {time} )." + "\n";
            }

            return output;
        }
    }
}

using RWSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class ReleasesStatementTranslator : BaseTranslator
    {
        //Translates 'A releases f if <condition>'
        //into 'releases(A, f, <condition>).'
        public override string Translate(string[] tokens)
        {
            string action = tokens[0];
            
            int indexOfReleases = Array.IndexOf(tokens, Token.Releases.Value);
            int indexOfIf = Array.IndexOf(tokens, Token.After.Value);
            string condition;
            string fluent;
            if (indexOfIf < 0)
            {
                condition = "[]";
                fluent = TranslateFormula(tokens.SubArray(indexOfReleases + 1, tokens.Length));
            }
            else
            {
                condition = TranslateFormula(tokens.SubArray(indexOfIf + 1, tokens.Length));
                fluent = TranslateFormula(tokens.SubArray(indexOfReleases + 1, indexOfIf));
            }
           

            return $"releases({action}, {fluent}, {condition}).";
        }
  }
}

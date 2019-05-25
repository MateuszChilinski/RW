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
          string fluent = tokens[indexOfReleases + 1];
        
          int indexOfIf = Array.IndexOf(tokens, Token.After.Value);
          string condition = TranslateFormula(tokens.SubArray(indexOfIf, tokens.Length));
        
          return $"releases({action}, {fluent}, {condition}).";
        }
  }
}

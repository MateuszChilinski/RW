using RWSystem.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Translation
{
    class InvokesStatementTranslator : BaseTranslator
    {
        //Translates 'Action invokes ResultAction after delay if <condition>'
        //into 'invokes(Action, ResultAction, delay, <condition>).'
        public override string Translate(string[] tokens)
        {
            string action = tokens[0].ToLower();

            int indexOfInvokes = Array.IndexOf(tokens, Token.Invokes.Value);
            string resultAction = tokens[indexOfInvokes + 1].ToLower();
             
            int indexOfAfter = Array.IndexOf(tokens, Token.After.Value);
            int delay = 0;
            if(indexOfAfter > 0)
                if (!int.TryParse(tokens[indexOfAfter + 1], out delay) || delay < 0)
                   throw new Exception("Parametr określający czas musi być dodatnią liczbą całkowitą!");

            int indexOfIf = Array.IndexOf(tokens, Token.If.Value);
            string condition = "[]";
            if(indexOfIf > 0)
                condition = TranslateFormula(tokens.SubArray(indexOfIf + 1, tokens.Length));
 
            return $"invokes({action}, {resultAction}, {delay.ToString(CultureInfo.InvariantCulture)}, {condition}).";
        }
    }
}

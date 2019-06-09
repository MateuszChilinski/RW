using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Utils
{
    public class FluentsContainer
    {
        private static FluentsContainer _instance;

        private HashSet<string> Fluents { get; set; }
        private HashSet<string> Negations { get; set; }

        public static FluentsContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FluentsContainer();
                }
                return _instance;
            }
        }


        private FluentsContainer()
        {
            Fluents = new HashSet<string>();
            Negations = new HashSet<string>();
        }

        public void AddFluent(string fluent)
        {
            var negFluent = "not_" + fluent;
            Fluents.Add(fluent);
            Fluents.Add(negFluent);
            Negations.Add($"negation({fluent}, {negFluent}).");
            Negations.Add($"negation({negFluent}, {fluent}).");
        }

        public string FluentsToString()
        {
            var result = new StringBuilder();

            foreach (var neg in Negations)
            {
                result.Append(neg + "\n");
            }
            //member(Fluent, [calm, not_calm, corruption, not_corruption]).

            result.Append("fluent(Fluent) :- \n \t");
            result.Append("member(Fluent, [");

            foreach (var fluent in Fluents)
            {
                result.Append($"{fluent}, ");
            }

            result.Remove(result.Length - 2, 2);
            result.Append("]).");

            return result.ToString();
        }

        public void Clear()
        {
            Fluents.Clear();
            Negations.Clear();
        }
    }
}

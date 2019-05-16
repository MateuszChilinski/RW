using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;

namespace RWSystem
{
    static class PrologSystem
    {
        public static string MakeQuery(string story, string query)
        {
            string filename = Path.GetTempFileName();
            StreamWriter sw = File.CreateText(filename);
            sw.Write(story);
            sw.Close();
            
            String[] param = { "-q", "-f", filename };
            try
            {
                PlEngine.Initialize(param);
                string queryResult = "Odpowiedź: ";
                using (PlQuery q = new PlQuery(query))
                {
                    if (q.NextSolution())
                        queryResult += "tak.";
                    else
                    {
                        queryResult += "nie.";
                    }
                }

                return queryResult;
            }
            catch (PlException e)
            {
                return e.MessagePl + "\n" + e.Message;
            }
            finally
            {
                PlEngine.PlCleanup();
            }

            return ""; // just in case xD
        }
    }
}

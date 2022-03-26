using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.String
{
    class CountNumberOfOccurance
    {
        static void Main()
        {
            string Input = "interview";

            FindTheNumberOfOccurance_v1(Input);
            FindTheNumberOfOccurance_v2(Input);
            Console.ReadLine();
        }

        private static void FindTheNumberOfOccurance_v2(string InputStr)
        {
            if (InputStr == null) return;
            if (InputStr == "") return;

            while(InputStr.Length > 0)
            {



            }


        }

        private static void FindTheNumberOfOccurance_v1(string InputStr)
        {
            if (InputStr == null) return;
            if (InputStr == "") return;

            Dictionary<string, int> CountDict = new Dictionary<string, int>();

            foreach (char s in InputStr)
            {
                if (CountDict.Keys.Contains(s.ToString()))
                    CountDict[s.ToString()]++;
                else
                    CountDict.Add(s.ToString(), 1);
            }


            foreach (KeyValuePair<string, int> dict in CountDict)
            {
                Console.WriteLine("{0} - {1}", dict.Key, dict.Value);
            }
            foreach (var dict in CountDict)
            {
                Console.WriteLine("{0} - {1}", dict.Key, CountDict[dict.Key]);
            }

        }
    }
}

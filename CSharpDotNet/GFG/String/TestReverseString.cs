using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.String
{
    class TestReverseString
    {
        static void Main()
        {
            var InputStr = "Hello World";
            var Result = ReverseMyString(InputStr);
            Console.WriteLine("InputStr: " + InputStr);
            Console.WriteLine("Reversed: " + Result);
            Console.ReadKey();
        }

        internal static string ReverseMyString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            return new string(charArray);
        }
    }
}

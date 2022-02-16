using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.StringIntern
{
    class TestStringIntern
    {
        static void Main()
        {
            string message = string.Intern("Hello CSharp");

            List<string> greetings = new List<string>();

            for (int i = 0; i < 10000; i++)
            {
                // Even the greetings contains 1000 copies of string
                // Only one copy is kept at the intern pool 
                // Intern pool is different than heap
                // Here the message is not kept under the heap, rather kept under the intern pool
                greetings.Add(message);
            }
            

            Console.ReadLine();
        }
    }
}

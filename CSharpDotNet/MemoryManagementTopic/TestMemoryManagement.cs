using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.MemoryManagementTopic
{
    class TestMemoryManagement
    {
        
        static void Main()
        {
            string a = "Hello World";
            string b = "Hello World";

            


            Console.WriteLine(a == b);
            Console.WriteLine(Object.ReferenceEquals(a, b));


            Console.ReadLine();
        }
    }
}

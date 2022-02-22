using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.CheckedKeywordTopic
{
    class TestCheckedKeyword
    {
        static void Main()
        {
            int ten = 10;
            double result = 0;
            //result = 2147483647 + 10; //CE
            Console.WriteLine(result);
            Console.WriteLine(2147483647 + ten);
            //Console.WriteLine(checked(2147483647 + ten)); //RE
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AttributeTopic
{
    [HelpMessage("This class is for verification of Attribute HelpMessage", false)]
    class TestHelpMessageAttribute
    {
        static void Main()
        {
            Method1();
            Method2();

            Console.ReadLine();
        }

        [HelpMessage("This method does some UI related work", false)]
        public static void Method1()
        {

        }

        [HelpMessage("This method does some Backend related work", true)]
        public static void Method2()
        {

        }
    }
}

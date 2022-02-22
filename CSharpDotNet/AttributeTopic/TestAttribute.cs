using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AttributeTopic
{
    [Obsolete("This class is depricated. Please implement a new class and make use of it", true)]
    class TestAttribute
    {
        static void Main()
        {
            TestMethod(); //Here it gives a warning informing this method is depricated. Suggesting to create a new method and use.

            TestMethodNew();
            Console.ReadLine();
        }

        [Obsolete]
        public static void TestMethod()
        {
            //some code
        }

        public static void TestMethodNew()
        {
            //some code
        }

        public void TestNonStaticMethod()
        {
            //some code
        }
    }

    class TestAttribute2  
    {
        static void Main() 
        {
            //new TestAttribute().TestNonStaticMethod(); //CE => Here it gives a warning informing this class is depricated. Suggesting to create a new class and use.
            //TestAttribute.TestMethod(); //CE => Here it gives a warning informing this class is depricated. Suggesting to create a new class and use.
            //TestAttribute.TestMethodNew(); //CE => Here it gives a warning informing this class is depricated. Suggesting to create a new class and use.         

            Console.ReadLine();
        }
    }
}

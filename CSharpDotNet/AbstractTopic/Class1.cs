using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AbstractTopic
{
    class Class1 : TestAbsClass1
    {
        public override void Test2()
        {
            Console.WriteLine("Test 2");
        }

        static void Main()
        {
            TestAbsClass1.Test1();

            Class1 class1 = new Class1();
            class1.Test2();

            // Abstract class instance can't be created but reference can be created by using the child class instance
            // AbstractReference can call the methods overriden in child class. This is possible.
            TestAbsClass1 abstractReference = class1;
            abstractReference.Test2();

        }
    }
}

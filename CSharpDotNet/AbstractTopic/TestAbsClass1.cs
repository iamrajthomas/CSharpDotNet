using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AbstractTopic
{
    abstract class TestAbsClass1
    {
        /// <summary>
        /// This is Concrete Class
        /// </summary>
        public static void Test1()
        {
            Console.WriteLine("Test 1");
        }

        /// <summary>
        /// Error CS0112  A static member 'TestAbsClass1.Test2()' cannot be marked as override, virtual, or abstract 
        /// </summary>
        //public static abstract void Test2();

        /// <summary>
        /// Error CS0513	'TestAbsClass1.Test2()' is abstract but it is contained in non-abstract class 'TestAbsClass1'
        /// </summary>
        public abstract void Test2();

    }
}

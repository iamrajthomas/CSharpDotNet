using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.InterfaceTopic
{
    public class TestInterface : Interface1, Interface2
    {
        public static void Main(string[] arge)
        {
            TestInterface ti = new TestInterface();
            ti.Test();
            // ti.Show(); // ERROR

            Interface1 i1 = ti;
            i1.Test();
            i1.Show();

            Interface2 i2 = ti;
            i2.Test();
            i2.Show();
        }

        /// <summary>
        /// Approach - 1
        /// </summary>
        public void Test()
        {
            Console.WriteLine("Test Method Invoked");
        }

        /// <summary>
        /// Approach - 2
        /// </summary>
        void Interface1.Show()
        {
            Console.WriteLine("Interface1.Show Method Invoked");
        }

        /// <summary>
        /// Approach - 2
        /// </summary>
        void Interface2.Show()
        {
            Console.WriteLine("Interface2.Show Method Invoked");
        }
    }


}

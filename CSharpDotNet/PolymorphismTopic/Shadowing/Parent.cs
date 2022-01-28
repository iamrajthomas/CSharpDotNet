using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.PolymorphismTopic.Shadowing
{
    class Parent
    {
        public virtual void Test1()
        {
            Console.WriteLine("Test 1 Parent");
        }
        public void Test2()
        {
            Console.WriteLine("Test 2 Parent");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.MultiThreadingWithTaskParallelLibraryTopic
{
    class TestTPL
    {
        static void Main()
        {
            Test1();
            Test2();

            Console.ReadLine();
        }

        static void Test1()
        {
            Task.Factory.StartNew(() => Console.WriteLine("Test1"));
        }

        static void Test2()
        {
            Task.Factory.StartNew(() => Console.WriteLine("Test2"));
        }
    }
}

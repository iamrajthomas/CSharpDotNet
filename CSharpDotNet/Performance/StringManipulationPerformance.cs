using System;
using System.Diagnostics;
using System.Text;

namespace CSharpDotNet.Performance
{
    class StringManipulationPerformance
    {
        static void Main()
        {
            TestPerformance();
            Console.ReadLine();
        }

        public static void TestPerformance()
        {
            const double Loop_MaxLimit = 100000;

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string stringValue = "Hi...";
            for (int i = 0; i < Loop_MaxLimit; i++)
            {
                stringValue = stringValue + i;
            }
            sw1.Stop();
            Console.WriteLine("Time Taken By To String to Manipulate: " + sw1.ElapsedMilliseconds + " Milliseconds");
            Console.WriteLine("Time Taken By To String to Manipulate: " + sw1.ElapsedTicks + " Ticks");

            Console.WriteLine("=========================================================================================");

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            StringBuilder sb = new StringBuilder("Hi...");
            for (int i = 0; i < Loop_MaxLimit; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time Taken By To StringBuilder to Manipulate: " + sw2.ElapsedMilliseconds + " Milliseconds");
            Console.WriteLine("Time Taken By To StringBuilder to Manipulate: " + sw2.ElapsedTicks + " Ticks");

        }
    }
}

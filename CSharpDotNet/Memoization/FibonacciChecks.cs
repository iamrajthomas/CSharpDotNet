using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.Memoization
{
    public class FibonacciChecks
    {
        public static long[] my_memo;
        public static DateTime my_time;
        public static Stopwatch my_stopWatch;
        public static long my_counter;

        static void Main()
        {
            TestMemoization();
        }

        public static void TestMemoization()
        {
            Console.WriteLine("Enter number between 2 and 1300 for Fibonacci calculation:");
            long k = long.Parse(Console.ReadLine());
            my_memo = new long[k + 1];
            Console.WriteLine("==================================================================");

            my_counter = 0;
            my_time = DateTime.Now;
            my_stopWatch = new Stopwatch();
            my_stopWatch.Reset();
            my_stopWatch.Start();

            Console.WriteLine("\n{0}", FibWithMemo(k, true));
            Console.WriteLine("Calculations {0}", my_counter);
            my_stopWatch.Stop();
            Console.WriteLine(DateTime.Now - my_time);
            Console.WriteLine("StopWatch For Fib With Memoization: {0}", my_stopWatch.ElapsedTicks);


            Console.WriteLine("==================================================================");

            my_counter = 0;
            my_stopWatch.Reset();
            my_stopWatch.Start();
            my_time = DateTime.Now;

            Console.WriteLine("\n{0}", FibWithMemo(k, false));
            Console.WriteLine("Calculations {0}", my_counter);
            my_stopWatch.Stop();
            Console.WriteLine(DateTime.Now - my_time);
            Console.WriteLine("StopWatch For  Without Memoization: {0}", my_stopWatch.ElapsedTicks);


            Console.WriteLine("==================================================================");

            my_stopWatch.Reset();
            my_stopWatch.Start();
            //Here we already have the first two numbers, so it is a bit unfair
            my_counter = 2;
            my_time = DateTime.Now;

            Console.WriteLine("\n{0}", FibWithLoop(k));
            Console.WriteLine("Calculations {0}", my_counter);
            Console.WriteLine(DateTime.Now - my_time);
            Console.WriteLine("StopWatch For FibWithLoop: {0}", my_stopWatch.ElapsedTicks);
            my_stopWatch.Reset();

            Console.ReadLine();
        }

        static long FibWithLoop(long counter_inside)
        {
            long f1 = 1;
            long f2 = 1;
            long f_result = 0;

            for (my_counter = 2; my_counter < counter_inside; my_counter++)
            {
                f_result = f1 + f2;
                f1 = f2;
                f2 = f_result;
            }

            return f_result;
        }

        static long FibWithMemo(long counter_inside, bool with_memo)
        {
            if (with_memo)
            {
                if (my_memo[counter_inside] != 0) return my_memo[counter_inside];
            }

            my_counter++;

            if (counter_inside == 0) return 0;
            if (counter_inside == 1) return 1;
            my_memo[counter_inside] = FibWithMemo(counter_inside - 1, with_memo) + FibWithMemo(counter_inside - 2, with_memo);
            return my_memo[counter_inside];
        }
    }
}

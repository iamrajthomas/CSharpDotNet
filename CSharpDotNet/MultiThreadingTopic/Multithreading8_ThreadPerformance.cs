using System;
using System.Diagnostics;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading8_ThreadPerformance
    {
        static long MaxLimit = 100000000; //Ten Crore or Hundred Million
        static void IncrementCounterOne()
        {
            long count = 0;
            for (int i = 0; i < MaxLimit; i++)
            {
                count += i; 
            }
            Console.WriteLine("Count1: " + count);
        }
        static void IncrementCounterTwo()
        {
            long count = 0;
            for (int i = 0; i < MaxLimit; i++)
            {
                count += i;
            }
            Console.WriteLine("Count2: " + count);
        }

        static void Main()
        {
            TestPerfWithSingleThreadedModel();
            TestPerfWithMultiThreadedModel();

            Console.ReadLine();
        }

        static void TestPerfWithSingleThreadedModel()
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            IncrementCounterOne();
            IncrementCounterTwo();
            sw1.Stop();

            Console.WriteLine("Elapsed Time in milliseconds for Single Threaded Model: " + sw1.ElapsedMilliseconds);
        }

        static void TestPerfWithMultiThreadedModel()
        {
            Thread T1 = new Thread(IncrementCounterOne);
            Thread T2 = new Thread(IncrementCounterTwo);
            
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            T1.Start();
            T2.Start();
            sw1.Stop();

            T1.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T1 is exited
            T2.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T2 is exited

            Console.WriteLine("Elapsed Time in milliseconds for Multi Threaded Model: " + sw1.ElapsedMilliseconds);
        }


    }
}

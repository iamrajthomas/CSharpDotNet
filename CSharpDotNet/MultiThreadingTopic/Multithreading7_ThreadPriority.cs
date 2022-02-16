using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading7_ThreadPriority
    {
        static double Count1, Count2;
        static void Increment1()
        {
            while (true)
            {
                Count1 += 1;
            }
        }
        static void Increment2()
        {
            while (true)
            {
                Count2 += 1;
            }
        }

        static void Main()
        {
            Console.WriteLine("Main Thread started");
            Thread T1 = new Thread(Increment1); 
            Thread T2 = new Thread(Increment2);

            T1.Priority = ThreadPriority.Lowest; //Setting this priority lowest, so that there's minimum CPU utilization for this thread
            T2.Priority = ThreadPriority.Highest; //Setting this priority highest, so that there's maximum CPU utilization for this thread

            T1.Start();
            T2.Start();

            Console.WriteLine("Main Thread is going to sleep");
            Thread.Sleep(10000);
            Console.WriteLine("Main Thread work up");

            T1.Abort();
            T2.Abort();

            T1.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T1 is exited
            T2.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T2 is exited


            Console.WriteLine("Count1: " + Count1);
            Console.WriteLine("Count2: " + Count2);
            Console.ReadLine();
        }
    }
}

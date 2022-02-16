using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading5_join
    {
        static void Method1()
        {
            Console.WriteLine("T1 thread is started");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1: " + i);
            }
            Console.WriteLine("T1 thread is exiting");

        }
        static void Method2()
        {
            Console.WriteLine("T2 thread is started");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method2: " + i);
                if (i == 2)
                {
                    Console.WriteLine("Method2 will go to sleep for sometime. Simulating DB operation with some Server/ DB Busy operation.");
                    Thread.Sleep(5000);
                    Console.WriteLine("Method2 woke up now.");
                }

            }
            Console.WriteLine("T2 thread is exiting");

        }
        static void Method3()
        {
            Console.WriteLine("T3 thread is started");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method3: " + i);
            }
            Console.WriteLine("T3 thread is exiting");

        }

        static void Main()
        {
            Console.WriteLine("Multithreading5");
            Console.WriteLine("Main thread is started");

            Thread T1 = new Thread(Method1);
            Thread T2 = new Thread(Method2);
            Thread T3 = new Thread(Method3);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T1 is exited
            //T2.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T2 is exited
            T3.Join(); //This blocks the caller thread till the calling thread is completed i.e. Main Thread won't exit until T3 is exited

            T2.Join(2000); //This blocks the caller thread for specified milliseconds i.e. Main Thread won't exit till 5 seconds and then exits

            Console.WriteLine("Main thread is exiting");

            Console.ReadLine();
        }



    }
}

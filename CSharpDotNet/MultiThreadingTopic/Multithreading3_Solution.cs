using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading3_Solution
    {
        static void Method1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1: " + i);
            }
        }
        static void Method2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method2: " + i);
                if(i == 2)
                {
                    Console.WriteLine("Method2 will go to sleep for sometime. Simulating DB operation with some Server/ DB Busy operation.");
                    Thread.Sleep(5000);
                    Console.WriteLine("Method2 woke up now.");
                }

            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method3: " + i);
            }
        }

        static void Main()
        {
            Console.WriteLine("Multithreading3");

            Thread T1 = new Thread(Method1);
            Thread T2 = new Thread(Method2);
            Thread T3 = new Thread(Method3);


            T1.Start();
            T2.Start();
            T3.Start();
            Console.ReadLine();
        }

    }
}

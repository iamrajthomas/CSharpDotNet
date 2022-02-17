using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading6_1_ThreadWithMonitor
    {
        private static object _lockObj = new object();
        static void Main()
        {
            //TestCriticalPrintUsingMonitor();
            Console.WriteLine("====================================================");
            TestCriticalPrintUsingMonitorWithIsLockTaken();

            Console.ReadLine();

        }

        static void TestCriticalPrintUsingMonitor()
        {
            Thread[] Threads = new Thread[5];
            for (int i = 0; i < Threads.Length; i++)
            {
                Threads[i] = new Thread(CriticalPrintUsingMonitor);
                Threads[i].Name = "Child Thread " + i;
            }
            foreach (Thread t in Threads)
            {
                t.Start();
            }
            
        }

        static void TestCriticalPrintUsingMonitorWithIsLockTaken()
        {
            Thread[] Threads = new Thread[5];
            for (int i = 0; i < Threads.Length; i++)
            {
                Threads[i] = new Thread(CriticalPrintUsingMonitorWithIsLockTaken);
                Threads[i].Name = "Child Thread " + i;
            }
            foreach (Thread t in Threads)
            {
                t.Start();
            }

        }

        static void CriticalPrintUsingMonitor()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Before Trying to enter into the critical section");
            Monitor.Enter(_lockObj);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                for (int i = 1; i <= 15; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(_lockObj);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
            }
        }

        static void CriticalPrintUsingMonitorWithIsLockTaken()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Before Trying to enter into the critical section");
            bool lockTaken = false; 
            Monitor.Enter(_lockObj, ref lockTaken);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                for (int i = 1; i <= 15; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(_lockObj);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
            }
        }
    }
}

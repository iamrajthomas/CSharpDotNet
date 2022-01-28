using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDotNet.SemaphoreTopic
{
    class TestSemaphore
    {
        static Semaphore semaPhore = new Semaphore(5, 5);
        static void Main(string[] args)
        {
            Console.WriteLine("TOP START THREAD ID : " + Thread.CurrentThread.ManagedThreadId);

            Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 15; ++i)
                {
                    Console.WriteLine("INSIDE FACTORY STARTNEW ID : " + Thread.CurrentThread.ManagedThreadId);
                    PrintSomething(i);
                    if (i % 5 == 0)
                    {
                        Thread.Sleep(2000);
                    }
                }
            });
            Console.WriteLine("TOP END THREAD ID : " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
            Console.ReadLine();
        }

        private static void PrintSomething(int i)
        {
            Console.WriteLine("INSIDE PrintSomething ID : " + Thread.CurrentThread.ManagedThreadId);

            semaPhore.WaitOne();
            Console.WriteLine(i);
            semaPhore.Release();
        }
    }
}

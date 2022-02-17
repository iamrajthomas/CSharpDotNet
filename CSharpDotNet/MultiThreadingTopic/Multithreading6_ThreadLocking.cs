using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading6_ThreadLocking
    {
        public void DisplayProblem()
        {
            Console.Write("[A language that doesn't affect the way ");
            Thread.Sleep(5000);
            Console.WriteLine("you think about programming is not worth knowing. - Alan J. Perlis]");
        }
        public void DisplayNonStaticSolutionWithLock()
        {
            lock (this)
            {
                Console.Write("[A language that doesn't affect the way ");
                Thread.Sleep(5000);
                Console.WriteLine("you think about programming is not worth knowing. - Alan J. Perlis]");
            }
        }

        private static object _lockObj = new object();
        public static void DisplayStaticSolutionWithLock()
        {
            lock (_lockObj)
            {
                Console.Write("[A language that doesn't affect the way ");
                Thread.Sleep(5000);
                Console.WriteLine("you think about programming is not worth knowing. - Alan J. Perlis]");
            }
        }

        static void Main()
        {
            Multithreading6_ThreadLocking obj = new Multithreading6_ThreadLocking();

            Thread T1 = new Thread(obj.DisplayProblem);
            Thread T2 = new Thread(obj.DisplayProblem);
            Thread T3 = new Thread(obj.DisplayProblem);
            T1.Start();
            T2.Start();
            T3.Start();

            //Thread T4 = new Thread(obj.DisplayNonStaticSolutionWithLock);
            //Thread T5 = new Thread(obj.DisplayNonStaticSolutionWithLock);
            //Thread T6 = new Thread(obj.DisplayNonStaticSolutionWithLock);
            //T4.Start();
            //T5.Start();
            //T6.Start();

            //Thread T7 = new Thread(DisplayStaticSolutionWithLock);
            //Thread T8 = new Thread(DisplayStaticSolutionWithLock);
            //Thread T9 = new Thread(DisplayStaticSolutionWithLock);
            //T7.Start();
            //T8.Start();
            //T9.Start();

            Console.ReadLine();

        }

    }
}

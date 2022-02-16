using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading6_ThreadLocking
    {
        public void DisplayProblem()
        {
            Console.Write("[CSharp is an ");
            Thread.Sleep(5000);
            Console.WriteLine("Object Oriented Programming Language]");
        }
        public void DisplaySolutionWithLock()
        {
            lock (this)
            {
                Console.Write("[CSharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Programming Language]");
            }
        }

        static void Main()
        {
            Multithreading6_ThreadLocking obj = new Multithreading6_ThreadLocking();

            //Thread T1 = new Thread(obj.DisplayProblem);
            //Thread T2 = new Thread(obj.DisplayProblem);
            //Thread T3 = new Thread(obj.DisplayProblem);
            //T1.Start();
            //T2.Start();
            //T3.Start();
            
            Thread T4 = new Thread(obj.DisplaySolutionWithLock);
            Thread T5 = new Thread(obj.DisplaySolutionWithLock);
            Thread T6 = new Thread(obj.DisplaySolutionWithLock);
            T4.Start();
            T5.Start();
            T6.Start();

            Console.ReadLine();

        }

    }
}

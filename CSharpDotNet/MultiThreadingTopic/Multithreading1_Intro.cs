using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading1_Intro
    {
        static void Main()
        {
            Console.WriteLine("Multithreading1"); 
            Thread t = Thread.CurrentThread;
            Console.WriteLine("Thread: " + t.Name); //Here Thread doesn't have a name by default

            t.Name = "Main Thread";
            Console.WriteLine("Thread Name (t.name): " + t.Name); //Here Thread name is set and prints name
            Console.WriteLine("Thread Name (Thread.CurrentThread.Name): " + Thread.CurrentThread.Name);  //Here Thread name is set and prints 
            Console.WriteLine("Thread IsAlive: " + Thread.CurrentThread.IsAlive);  //Here Thread name is set and prints 
            Console.WriteLine("Thread IsBackground: " + Thread.CurrentThread.IsBackground);  //Here Thread name is set and prints 
            Console.ReadLine();
        }


    }
}

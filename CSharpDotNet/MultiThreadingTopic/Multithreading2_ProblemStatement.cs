using System;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading2_ProblemStatement
    {
        static void Method1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1: " + i);
            }
        }
        static void Method2()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method2: " + i);
            }
        }
        static void Method3()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method3: " + i);
            }
        }

        static void Main()
        {
            Console.WriteLine("Multithreading2");

            Method1();
            Method2();
            Method3();
            Console.ReadLine();
        }

    }
}

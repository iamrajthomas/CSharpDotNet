using System;
using System.Threading;

namespace CSharpDotNet.MultiThreadingTopic
{
    class Multithreading4_ctor
    {
        static void Test1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
        }

        static void Test2(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Test2: " + i);
            }
        }

        static void Main()
        {
            Console.WriteLine("Multithreading4");

            InvokeTest1WithThreadStartDelegate();
            Console.WriteLine("==========================================================");

            InvokeTest1WithParameterizedThreadStartDelegate();
            Console.ReadLine();
        }

        static void InvokeTest1WithThreadStartDelegate()
        {
            // Approach - 1 to call the method using Thread
            //Thread t = new Thread(Test1);

            // Approach - 2 to call the method using Thread with delegate
            // CTOR of thread takes delegate as a parameter
            // ThreadStart is a delegate with non value return with no input
            // ParameterizedThreadStart is a non value returning with object as input

            // Approach by binding using the delegate
            //ThreadStart threadStart = new ThreadStart(Test1); //Instantiate the delegate and bind the method with traditional approach
            //ThreadStart threadStart = Test1; //Instantiate the delegate and bind the method directly using method name
            //ThreadStart threadStart = delegate() { Test1();  }; //Instantiate the delegate and bind the method using delegate keyword and anonymous method
            ThreadStart threadStart = () => Test1();  //Instantiate the delegate and bind the method using lamda expression

            Thread t = new Thread(threadStart);

            t.Start();
        }

        static void InvokeTest1WithParameterizedThreadStartDelegate()
        {
            // Approach - 1 to call the method using Thread
            //Thread t = new Thread(Test2);

            // Approach - 2 to call the method using Thread with delegate
            // CTOR of thread takes delegate as a parameter
            // ThreadStart is a delegate with non value return with no input
            // ParameterizedThreadStart is a non value returning with object as input

            // Approach by binding using the delegate
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Test2); //Instantiate the delegate and bind the method with traditional approach
            //ParameterizedThreadStart parameterizedThreadStart = Test2; //Instantiate the delegate and bind the method directly using method name
            //ThreadStart parameterizedThreadStart = delegate() { Test2(100);  }; //Instantiate the delegate and bind the method using delegate keyword and anonymous method but in this case start() doesn't need any parameter as anonymous method is passed with parameter
            //ThreadStart parameterizedThreadStart = () => Test2(200);  //Instantiate the delegate and bind the method using lamda expression

            Thread t = new Thread(parameterizedThreadStart);

            t.Start(15);
        }

    }
}

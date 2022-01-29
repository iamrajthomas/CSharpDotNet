using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DelegateTopic
{
    // Step - 1: Define Delegate 
    public delegate void AddNumsDelegate(int x, int y);
    public delegate string SayHelloDelegate(string inputValue);

    class TestDelegate
    {
        /// <summary>
        /// Non-Static Method Adds Two Intergers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        /// <summary>
        /// Static Methods SayHello
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }

        /// <summary>
        /// Operation Without use of Degelate
        /// </summary>
        public static void PerformWithoutDelegateRelatedOperation()
        {
            TestDelegate testDelegate = new TestDelegate();
            testDelegate.AddNums(10, 20);
            var result = SayHello("Alex");
            Console.WriteLine(result);
        }

        /// <summary>
        /// All Delegate Related Operation
        /// </summary>
        public static void PerformDelegateRelatedOperation()
        {
            TestDelegate testDelegateInstance = new TestDelegate();
            // Step - 2: Instantiate the delegate by passing method as parameter matching its signature
            // Here AddNums() is accessed with the instance of TestDelegate since it's a non-static method
            AddNumsDelegate addNumsDelegate = new AddNumsDelegate(testDelegateInstance.AddNums);

            //Step - 3: Call the delegate by passing required parameter values, so that internally the method which is bound with the delegate gets executed.
            addNumsDelegate(50, 60);

            // Another Approach to call with delegate is with Invoke method
            addNumsDelegate.Invoke(50, 60);

            // ======================================================================================================================================================
            // ======================================================================================================================================================

            // Step - 2: Instantiate the delegate by passing method as parameter matching its signature
            // Here SayHello() is accessed with the class name TestDelegate since it's a static method
            SayHelloDelegate sayHello = new SayHelloDelegate(TestDelegate.SayHello);

            //Step - 3: Call the delegate by passing required parameter values, so that internally the method which is bound with the delegate gets executed.
            var result = sayHello("William");
            Console.WriteLine(result);

            // Another Approach to call with delegate is with Invoke method
            result = sayHello.Invoke("William");
            Console.WriteLine(result);

        }

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main()
        {
            PerformWithoutDelegateRelatedOperation();

            Console.WriteLine("=============================================================");

            PerformDelegateRelatedOperation();
            Console.ReadLine();
        }
    }
}

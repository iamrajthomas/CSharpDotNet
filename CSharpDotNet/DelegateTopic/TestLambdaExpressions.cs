using System;

namespace CSharpDotNet.DelegateTopic
{
    class TestLambdaExpressions
    {
        public string Greetings(string Name)
        {
            return "Hello " + Name + "...!! Good Morning..!!!!";
        }

        static void TestDelegate()
        {
            TestAnonymousMethods testAnonymousMethods = new TestAnonymousMethods();
            GreetingsDelegate greetingsDelegate = new GreetingsDelegate(testAnonymousMethods.Greetings);
            //GreetingsDelegate greetingsDelegate = testAnonymousMethods.Greetings; // Another approach of delegate instantiation

            Console.WriteLine(greetingsDelegate("Albert Einstein"));
            Console.WriteLine(greetingsDelegate.Invoke("Issac Newton"));
        }

        static void TestDelegateWithAnonymousMethods()
        {
            TestAnonymousMethods testAnonymousMethods = new TestAnonymousMethods();
            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(testAnonymousMethods.Greetings); // An approach of delegate instantiation
            //GreetingsDelegate greetingsDelegate = testAnonymousMethods.Greetings; // Another approach of delegate instantiation

            // This is an anonymous method which is bound to a delegate
            GreetingsDelegate greetingsDelegate = delegate (string Name)
            {
                return "Hello " + Name + "...!! Good Morning..!!!!";
            };

            Console.WriteLine(greetingsDelegate("Albert Einstein"));
            Console.WriteLine(greetingsDelegate.Invoke("Issac Newton"));
        }

        static void TestDelegateWithLambdaExpressions()
        {
            TestAnonymousMethods testAnonymousMethods = new TestAnonymousMethods();
            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(testAnonymousMethods.Greetings); // An approach of delegate instantiation
            //GreetingsDelegate greetingsDelegate = testAnonymousMethods.Greetings; // Another approach of delegate instantiation

            // This is an LambdaExpressions with an anonymous method which is bound to a delegate 
            // Here unlike anonymous methods, no need to write delegate keyword and specify type of input parameters, since the delegate is well aware of it
            GreetingsDelegate greetingsDelegate = (Name) =>
            {
                return "Hello " + Name + "...!! Good Morning..!!!!";
            };

            Console.WriteLine(greetingsDelegate("Albert Einstein"));
            Console.WriteLine(greetingsDelegate.Invoke("Issac Newton"));
        }

        public static void Main()
        {
            TestDelegate();
            Console.WriteLine("=======================================================================================================");
            TestDelegateWithAnonymousMethods();
            Console.ReadLine();
        }
    }
}

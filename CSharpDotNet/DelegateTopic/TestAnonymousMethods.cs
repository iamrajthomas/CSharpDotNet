using System;

namespace CSharpDotNet.DelegateTopic
{
    public delegate string GreetingsDelegate(string Name);
    class TestAnonymousMethods
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

        public static void Main()
        {
            TestDelegate();
            Console.WriteLine("=======================================================================================================");
            TestDelegateWithAnonymousMethods();
            Console.ReadLine();
        }
    }
}

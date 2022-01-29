using System;

namespace CSharpDotNet.DelegateTopic
{
    public delegate double TestDelegate1(int x, float y, double z);
    public delegate void TestDelegate2(int x, float y, double z);
    public delegate bool TestDelegate3(string str);

    class GenericDelegates
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckStatus(string InputValue)
        {
            if (InputValue.Length > 5)
                return true;
            return false;
        }

        static void TestWithUserDefinedDelegates()
        {
            TestDelegate1 testDelegate1 = new TestDelegate1(AddNums1); //Approach - 1 for instantiating delegate
            double Result = testDelegate1(10, 34.56f, 67.89); //Approach - 1 for Invoking delegate
            Console.WriteLine(Result);

            TestDelegate2 testDelegate2 = AddNums2; //Approach - 2 for instantiating delegate
            testDelegate2.Invoke(10, 34.56f, 67.89); //Approach - 2 for Invoking delegate

            TestDelegate3 testDelegate3 = CheckStatus;
            bool Status = testDelegate3("Hello World");
            Console.WriteLine(Status);
        }

        /// <summary>
        /// Pre-Defined Generic Delegate Are:
        /// Func Delegate: Value Returning Delegate
        /// Action Delegate: Non-Value Returning Delegate
        /// Predicate Delegate: Bool Value Returning Delegate
        /// </summary>
        static void TestWithPreDefinedGenericDelegates()
        {
            Func<int, float, double, double> func = new Func<int, float, double, double>(AddNums1); //Approach - 1 for instantiating delegate
            //Func<int, float, double, double> func = AddNums1; //Approach - 2 for instantiating delegate
            double result = func(10, 34.56f, 67.89); //Approach - 1 for Invoking delegate
            Console.WriteLine(result);

            Action<int, float, double> action = AddNums2;
            action.Invoke(10, 34.56f, 67.89); //Approach - 2 for Invoking delegate

            Predicate<string> predicate = CheckStatus;
            bool status = predicate("Hello World");
            Console.WriteLine(status);
        }

        /// <summary>
        /// Test Pre-Defined Generic Delegates With Anonymous Methods And Lamda Expressions
        /// Pre-Defined Generic Delegate Are:
        /// Func Delegate: Value Returning Delegate
        /// Action Delegate: Non-Value Returning Delegate
        /// Predicate Delegate: Bool Value Returning Delegate
        /// </summary>
        static void TestPreDefinedGenericDelegatesWithAnonymousMethodsAndLamdaExpressions()
        {
            // Func Delegate Doesn't make use of AddNum1() and invokes with an anonymous method and lamda expresion in a sinle line
            Func<int, float, double, double> func = (int x, float y, double z) => x + y + z;
            double result = func(10, 34.56f, 67.89);
            Console.WriteLine(result);

            // Action Delegate Doesn't make use of AddNum2() and invokes with an anonymous method and lamda expresion in a sinle line
            Action<int, float, double> action = (int x, float y, double z) => Console.WriteLine(x + y + z);
            action(10, 34.56f, 67.89);

            // Predicate Delegate Doesn't make use of CheckStatus() and invokes with an anonymous method and lamda expresion in multiple line
            Predicate<string> predicate = (string InputValue) =>
            {
                if (InputValue.Length > 5)
                    return true;
                return false;
            };

            bool status = predicate("Hello World");
            Console.WriteLine(status);
        }

        static void Main()
        {
            TestWithUserDefinedDelegates();
            Console.WriteLine("================================================");
            TestWithPreDefinedGenericDelegates();
            Console.WriteLine("================================================");
            TestPreDefinedGenericDelegatesWithAnonymousMethodsAndLamdaExpressions();
            Console.ReadLine();
        }
    }
}

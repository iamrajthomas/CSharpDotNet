using System;

namespace CSharpDotNet.CollectionTopic
{
    // Here Genric is not used
    // Only the problem is discussed here in this class
    // The solution is discussed in TestUserDefinedGenericClassWithSolution class
    // PROBLEM: The problem here is that we have defined 4 methods for the ADD, SUB, MUL AND DIV operation on int datatype only
    // If we have to make it work for float, double datatype then we again need to write same logic with input parameters are different datatypes as float, double
    class TestUserDefinedGenericClassWithProblem
    {
        void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        static void Main()
        {
            TestUserDefinedGenericClassWithProblem instance = new TestUserDefinedGenericClassWithProblem();
            instance.Add(100, 200);
            instance.Sub(100, 200);
            instance.Mul(100, 200);
            instance.Div(100, 200);

            Console.ReadLine();

        }
    }


}

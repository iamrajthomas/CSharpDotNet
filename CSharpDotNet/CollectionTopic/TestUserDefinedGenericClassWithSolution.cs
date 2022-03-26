using System;
using System.Collections.Generic;

namespace CSharpDotNet.CollectionTopic
{
    // Here Genric is not used
    // Only the problem is discussed here in this class
    // The solution is discussed in TestUserDefinedGenericClassWithSolution class
    // PROBLEM: The problem here is that we have defined 4 methods for the ADD, SUB, MUL AND DIV operation on T datatype only
    // If we have to make it work for float, double datatype then we again need to write same logic with input parameters are different datatypes as float, double
    // SOLUTION: We can define a generic class with TestUserDefinedGenericClassWithSolution<T>
    // The entire class can take any datatype and the datatype will be decided during instantiating the class (Just like List class), shown below
    // Instantiating: TestUserDefinedGenericClassWithSolution<T> obj = new TestUserDefinedGenericClassWithSolution<T>
    // The datatype will be dynamic 
    public class TestUserDefinedGenericClassWithSolutionMain<T> 
         // where T : short, int, double, float 
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }

        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
        
    }


    class TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<T1, T2>
    {
        public void Add(T1 a, T2 b)
        {
            dynamic d1 = a;
            dynamic d2 = a;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T1 a, T2 b)
        {
            dynamic d1 = a;
            dynamic d2 = a;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T1 a, T2 b)
        {
            dynamic d1 = a;
            dynamic d2 = a;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T1 a, T2 b) 
        {
            dynamic d1 = a;
            dynamic d2 = a;
            Console.WriteLine(d1 + d2);
        }
    }

    class TestUserDefinedGenericClassWithSolution
    {
        static void TestUserDefinedGenericClassWithSolutionMain_Class()
        {
            TestUserDefinedGenericClassWithSolutionMain<int> instance1 = new TestUserDefinedGenericClassWithSolutionMain<int>();
            instance1.Add(100, 200);
            instance1.Sub(100, 200);
            instance1.Mul(100, 200);
            instance1.Div(100, 200);

            Console.WriteLine("===================================");

            TestUserDefinedGenericClassWithSolutionMain<float> instance2 = new TestUserDefinedGenericClassWithSolutionMain<float>();
            instance2.Add(100.45f, 200.45f);
            instance2.Sub(100.45f, 200.45f);
            instance2.Mul(100.45f, 200.45f);
            instance2.Div(100.45f, 200.45f);

            Console.WriteLine("===================================");

            TestUserDefinedGenericClassWithSolutionMain<double> instance3 = new TestUserDefinedGenericClassWithSolutionMain<double>();
            instance3.Add(100.45, 200.45);
            instance3.Sub(100.45, 200.45);
            instance3.Mul(100.45, 200.45);
            instance3.Div(100.45, 200.45);


            // The Above Approach is similar to what we've in Generic List, shown below
            // List will be considered for the datatype mentioned during the instantiation 
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Insert(2, 25);
            list.Remove(10);

            List<float> list2 = new List<float>();
            list2.Add(12.34f);
            list2.Add(45.67f);
            list2.Insert(1, 789.789f);
            list2.RemoveAt(0);

        }

        static void TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput_Class()
        {
            TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<int, int> obj = new TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<int, int>();
            obj.Add(555, 333);
            obj.Sub(555, 333);
            obj.Div(555, 333);
            obj.Mul(555, 333);

            Console.WriteLine("===================================");
            TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<double, double> obj2 = new TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<double, double>();
            obj2.Add(555, 333.35f);
            obj2.Sub(555, 333.35f);
            obj2.Div(555, 333.35f);
            obj2.Mul(555, 333.35f);

            Console.WriteLine("===================================");
            TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<int, float> obj3 = new TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput<int, float>();
            obj3.Add(555, 333.35f);
            obj3.Sub(555, 333.35f);
            obj3.Div(555, 333.35f);
            obj3.Mul(555, 333.35f);

            Console.WriteLine("===================================");
        }

        static void Main()
        {
            TestUserDefinedGenericClassWithSolutionMain_Class();
            Console.WriteLine("******************************************************************************");
            TestUserDefinedGenericClassWithSolutionMainWithTwoGenericInput_Class();
            Console.ReadLine();

        }
    }
}

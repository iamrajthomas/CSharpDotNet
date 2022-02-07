using System;

namespace CSharpDotNet.CollectionTopic
{
    // Here Genric is used
    // The problem is discussed in TestUserDefinedGenericClassWithProblem class
    // The solution is discussed in this class
    // PROBLEM: The problem here is that we have defined 4 methods for the ADD, SUB, MUL AND DIV operation on int datatype only
    // If we have to make it work for float, double datatype then we again need to write same logic with input parameters are different datatypes as float, double
    // SOLUTION: We can define a generic method with Compare<T>(T a, T b), which can take any datatype and the datatype will be decided during calling the method, shown below
    // Calling: Compare<int>(10, 20); Compare<float>(12.34f, 12.34f); 
    // The datatype will be dynamic and may vary but the operation remains same i.e. Compare the two inputs
    class TestUserDefinedGenericMethodWithSolution
    {
        //static bool Compare(int a, int b)
        //{
        //    if (a.Equals(b))
        //        return true;
        //    return false;
        //}

        static bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        static void Main()
        {
            Console.WriteLine(Compare<int>(10, 20));
            Console.WriteLine(Compare<float>(12.34f, 12.34f));
            Console.WriteLine(Compare<double>(12.34, 12.34));

            //Console.WriteLine(Compare<float>(12.34f, 12.34)); //Compile Time Error // Safe Type Checking
            //Console.WriteLine(Compare<int>(12, 12.34f)); //Compile Time Error // Safe Type Checking
            //Console.WriteLine(Compare<string>("123", 123)); //Compile Time Error // Safe Type Checking


            Console.ReadLine();
        }
    }
}

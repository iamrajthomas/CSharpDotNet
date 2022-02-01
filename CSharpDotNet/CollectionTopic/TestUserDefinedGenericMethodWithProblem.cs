using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.CollectionTopic
{
    // Here Genric is not used
    // Only the problem is discussed here in this class
    // The solution is discussed in TestUserDefinedGenericMethodWithSolution class
    class TestUserDefinedGenericMethodWithProblem
    {
        // PROBLEM: The problem here is that we have defined separate methods for the same kind of work just for different types
        static bool Compare(int a, int b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static bool Compare(float a, float b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static bool Compare(double a, double b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        // Here, this accepts every type
        // Problem here are, 
        // 1. This method is not type safe 
        // 2. This method everytime makes the boxing/unboxing operation when called, will have perf impacts
        static bool Compare(object a, object b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        static void Main()
        {
            Console.WriteLine(Compare(10, 20));
            Console.WriteLine(Compare(10.45f, 20.54f)); //float comparision
            Console.WriteLine(Compare(12.34, 12.34)); //double comparision
            Console.WriteLine(Compare(12.00, 12)); // double comparision with int // Doesn't have type safe here
            Console.WriteLine(Compare("AA", 123)); // string comparision with int // Doesn't have type safe here

            Console.ReadLine();
        }


    }
}

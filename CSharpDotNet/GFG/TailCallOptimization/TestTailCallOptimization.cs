using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.TailCallOptimization
{
    class TestTailCallOptimization
    {
        static void Main()
        {
            //1 1 2 3 5 8 13 21 34 55 89

            var fibResult = Fibonacci(10);
            Console.WriteLine("Fibonacci result: " + fibResult);

            var fibResult2 = TailCallFibonacci(10);
            Console.WriteLine("TailCallFibonacci result: " + fibResult2);

            Console.ReadLine();
        }

        static long Fibonacci(int N)
        {
            if (N == 0 || N == 1)
                return 1;

            return Fibonacci(N - 1) + Fibonacci(N - 2);
        }

        static long TailCallFibonacci(int N, int a = 0, int b = 1)
        {
            if (N == 0)
                return b;

            return TailCallFibonacci(N - 1, b, a + b);
        }


    }
}

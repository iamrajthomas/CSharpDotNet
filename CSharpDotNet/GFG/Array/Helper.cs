using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.Array
{
    public static class Helper
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        public static void PrintArray(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        public static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        public static void PrintArray(List<string> arr)
        {
            for (int i = 0; i < arr.Count; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}

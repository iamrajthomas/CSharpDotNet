using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.Array
{
    public static class Array7
    {

        /// <summary>
        /// Cyclically rotate an array by one
        /// </summary>
        public static void Invoke()
        {
            int[] arr = { 9, 8, 7, 6, 4, 2, 1, 3 };

            Helper.PrintArray(arr);
            var result = Rotate(arr);

            Console.Write("Cyclically rotate an array by one \n");
            Helper.PrintArray(result);
        }


        public static int[] Rotate(int[] arr)
        {
            int[] result = new int[arr.Length];
            result[0] = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                result[i + 1] = arr[i];
            }

            return result;
        }
    }
}

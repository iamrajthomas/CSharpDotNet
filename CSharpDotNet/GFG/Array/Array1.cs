using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.Array
{
    public static class Array1
    {

        /// <summary>
        /// Write a program to reverse an array or string
        /// </summary>
        public static void Invoke()
        {
            int[] arr = { 1, 2, 3, 4, 4, 5, 6, 7, 8 };
            Helper.PrintArray(arr);
            RevereseArray(arr, 0, arr.Length - 1);

            Console.Write("Reversed array is \n");
            Helper.PrintArray(arr);
        }

        private static void RevereseArray(int[] arr, int start, int end)
        {
            int temp;
            for (; start < end; start++, end--)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
            }

            //while(start < end)
            //{
            //    temp = arr[start];
            //    arr[start] = arr[end];
            //    arr[end] = temp;
            //    start++;
            //    end--;
            //}

        }
    }
}

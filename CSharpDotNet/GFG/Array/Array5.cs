using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.Array
{
    public static class Array5
    {
        /// <summary>
        /// Move all negative numbers to beginning and positive to end with constant extra space
        /// </summary>
        public static void Invoke()
        {
            int[] arr = { -12, 11, -13, -5, 6, -7, 5, -3, 11 };
            int arr_size = arr.Length;

            Helper.PrintArray(arr);

            MoveAllNegativeToLeftAndPositiveToRightSide(arr, 0, arr_size - 1);

            Console.Write("Move All Negative To Left And Positive To Right Side \n");
            Helper.PrintArray(arr);
        }

        private static void MoveAllNegativeToLeftAndPositiveToRightSide(int[] arr, int start, int end)
        {
            int positionFlag = 0;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    temp = arr[i];
                    arr[i] = arr[positionFlag];
                    arr[positionFlag] = temp;
                    positionFlag++;
                }
            }

        }
    }
}

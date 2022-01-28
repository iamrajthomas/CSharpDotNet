using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.Array
{
    class Array4
    {
        /// <summary>
        /// Given an array which consists of only 0, 1 and 2. Sort the array without using any sorting algo
        /// Two Solutions Here
        /// </summary>
        public static void Invoke()
        {
            int[] arr = { 0, 2, 1, 2, 0 };
            Helper.PrintArray(arr);
            //SortedArrayWithSortingAlgo(arr, 0, arr.Length - 1);

            SortedArrayWithSortingAlgo_v2(arr, 0, arr.Length - 1); //More Efficient

            Console.Write("Sorted Array is \n");
            Helper.PrintArray(arr);
        }

        private static void SortedArrayWithSortingAlgo(int[] arr, int start, int end)
        {
            int CountZero = 0;
            int CountOne = 0;
            int CountTwo = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    CountZero++;
                }
                if (arr[i] == 1)
                {
                    CountOne++;
                }
                if (arr[i] == 2)
                {
                    CountTwo++;
                }
            }

            for (int i = 0; i < CountZero; i++)
            {
                arr[i] = 0;
            }

            for (int i = CountZero; i < (CountZero + CountOne); i++)
            {
                arr[i] = 1;
            }

            for (int i = (CountZero + CountOne); i < (CountZero + CountOne + CountTwo); i++)
            {
                arr[i] = 2;
            }
        }

        private static void SortedArrayWithSortingAlgo_v2(int[] arr, int start, int end)
        {
            int CountZero = 0;
            int CountOne = 0;
            int CountTwo = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    CountZero++;
                }
                if (arr[i] == 1)
                {
                    CountOne++;
                }
                if (arr[i] == 2)
                {
                    CountTwo++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(i < CountZero)
                {
                    arr[i] = 0;
                    continue;
                }

                if (i >= CountZero && i < (CountZero + CountOne))
                {
                    arr[i] = 1;
                    continue;
                }

                if (i >= (CountZero + CountOne) && i < (CountZero + CountOne + CountTwo))
                {
                    arr[i] = 2;
                }
            }
        }
    }
}

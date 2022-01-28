using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG.Array
{
    public static class Array6
    {
        /// <summary>
        /// Find the Union and Intersection of the two sorted arrays
        /// </summary>
        public static void Invoke()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 6, 4, 8, 7, 2 };

            Helper.PrintArray(arr1);
            Helper.PrintArray(arr2);
            //var result = UniqueOfTwoArray(arr1, arr2);
            //var result = UniqueOfTwoArray_v2(arr1, arr2);
            var result = UniqueOfTwoArray_v3(arr1, arr2);

            Console.Write("Find the Union and Intersection of the two sorted arrays \n");
            Helper.PrintArray(result);
        }

        /// <summary>
        /// only one of the array values can be unique and not for both the 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static List<int> UniqueOfTwoArray(int[] arr1, int[] arr2)
        {
            List<int> result = arr1.Length > arr2.Length ? arr1.ToList() : arr2.ToList();
            int position = result.Count;
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (!result.Contains(arr2[i]))
                    {
                        result.Add(arr2[i]);
                        //result[position] = arr2[i];
                        //position++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (!result.Contains(arr1[i]))
                    {
                        result.Add(arr1[i]);
                        //result[position] = arr1[i];
                        //position++;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// strictly wants all values in the array to be unique but also includes the default values 0 for the non-used indices
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static int[] UniqueOfTwoArray_v3(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int position = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!result.Contains(arr1[i]))
                {
                    result[position] = arr1[i];
                    position++;
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (!result.Contains(arr2[i]))
                {
                    result[position] = arr2[i];
                    position++;
                }
            }
            return result;
        }

        /// <summary>
        /// strictly wants all values in the array to be unique
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static List<int> UniqueOfTwoArray_v2(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!result.Contains(arr1[i]))
                    result.Add(arr1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (!result.Contains(arr2[i]))
                    result.Add(arr2[i]);
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.LINQ
{
    class TestWhere
    {
        static readonly List<int> NumbersList = Enumerable.Range(1, 100).ToList();

        static void Main()
        {
            PrintListData(NumbersList);
            Console.WriteLine("=================================================");
            FilterFirstFiveEvenNumbersFromGivenList(NumbersList);
            Console.WriteLine("=================================================");
            FilterArrayDataStructure();
            Console.WriteLine("=================================================");
            Console.ReadLine();
        }

        static void PrintListData(List<int> InputList)
        {
            Console.WriteLine();
            foreach (int Num in InputList)
            {
                Console.Write(Num + " ");
            }
        }

        static void FilterFirstFiveEvenNumbersFromGivenList(List<int> InputList)
        {
            var filtered = InputList.Where(x => x % 2 == 0).Take(5);
            PrintListData(filtered.ToList());

            var filtered3 = InputList.Where(x => x % 2 == 0);
            PrintListData(filtered.ToList());
        }

        static void FilterArrayDataStructure()
        {
            //Array
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            arr = arr.Where(x => x % 2 == 0).ToArray();
            PrintListData(arr.ToList());

        }
    }

    public static class WhereExtension
    {


        /// <summary>
        /// Approach - 1
        /// Non Lazy / Non Deferred execution
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        //public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Predicate<T> predicate)
        //public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        //{
        //    var resultValue = new List<T>();
        //    foreach (var item in items)
        //    {
        //        if (predicate(item))
        //        {
        //            resultValue.Add(item);
        //        }
        //    }

        //    return resultValue;
        //}

        ///// <summary>
        ///// Approach - 2
        ///// Lazy execution [Preferred One]
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="items"></param>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Predicate<T> predicate)
        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            var returnValue = new List<T>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

    }
}

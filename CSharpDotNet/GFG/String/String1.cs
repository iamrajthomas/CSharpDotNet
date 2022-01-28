using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDotNet.GFG.Array;

namespace CSharpDotNet.GFG.String
{
    public static class String1
    {
        /// <summary>
        /// Write a program to Reverse String
        /// </summary>
        public static void Invoke()
        {
            string[] strArray = { "h", "e", "l", "l", "o" };
            Helper.PrintArray(strArray);

            var result = ReverseString(strArray);
            Helper.PrintArray(result);
        }

        public static string[] ReverseString(string[] strArray)
        {
            string[] result = new string[strArray.Length];
            int position = 0;

            for (int i = strArray.Length - 1; i >= 0 ; i--)
            {
                result[position] = strArray[i];
                position++;
            }
            return result;
        }




    }
}

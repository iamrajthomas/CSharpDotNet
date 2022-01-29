using System;

namespace CSharpDotNet.ExtensionMethodTopic
{
    static class ExtensionStatic
    {
        /// <summary>
        /// This method won't be called since the LegacyApplication contains method with same name
        /// </summary>
        /// <param name="legacyApplication"></param>
        public static void Test2(this LegacyApplication legacyApplication)
        {
            Console.WriteLine("LegacyApplication Extension: Method 2");
        }

        /// <summary>
        /// This is an extension method to class LegacyApplication
        /// </summary>
        /// <param name="legacyApplication"></param>
        public static void Test3(this LegacyApplication legacyApplication)
        {
            Console.WriteLine("LegacyApplication Extension: Method 3");
        }

        /// <summary>
        /// This is an extension method with return type and input parameter to class LegacyApplication
        /// </summary>
        /// <param name="legacyApplication"></param>
        /// <param name="message"></param>
        public static string Test4(this LegacyApplication legacyApplication, string value)
        {
            return "LegacyApplication Extension: Method 4: " + value;
        }

        /// <summary>
        /// This is an extension method for Int32 i.e. Structure Type
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static long Factorial(this Int32 i)
        {
            if (i < 0)
                return i;
            if (i == 0)
                return 1;
            if (i == 1)
                return 1;
            if (i == 2)
                return 2;
            else
                return i * Factorial(i - 1);
        }

        /// <summary>
        /// This is an extension method for String Class
        /// This method converts any string into Proper Case
        /// </summary>
        /// <param name="originalStringValue"></param>
        /// <returns></returns>
        public static string ToProper(this string originalStringValue)
        {
            if(originalStringValue.Trim().Length > 0)
            {
                string newStringValue = null;
                originalStringValue = originalStringValue.ToLower();
                string[] splitStringArray = originalStringValue.Split(' ');
                foreach(string str in splitStringArray)
                {
                    char[] charArray = str.ToCharArray();
                    charArray[0] = Char.ToUpper(charArray[0]);
                    if (newStringValue == null)
                        newStringValue = new string(charArray);
                    else
                        newStringValue += " " + new string(charArray);
                }
                return newStringValue;
            }
            return originalStringValue;
        }
    }
}

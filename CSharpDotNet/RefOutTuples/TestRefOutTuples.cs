using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.RefOutTuples
{
    public class TestRefOutTuples
    {
        public static void Invoke()
        {
            TestRef();
            TestOut();
            TestTuple();

        }

        #region REF KEYWORD
        private static void TestRef()
        {
            string first = "Raj";
            var last = "Thomas";
            string FirstName = GetNameWithRefParameter(ref first, ref last);

            Console.WriteLine(FirstName + "  -- " + last);
        }

        public static string GetNameWithRefParameter(ref string FirstName, ref string LastName)
        {
            LastName = "Albert Einstein";
            return FirstName;
        }
        #endregion

        #region OUT KEYWORD
        public static string GetNameWithOutParameter(out string FirstName, out string LastName)
        {
            FirstName = "Rajesh"; // ERROR: The out parameter 'FirstName' must be assigned to before control leaves the current method
            LastName = "Albert Einstein"; // ERROR: The out parameter 'LastName' must be assigned to before control leaves the current method
            return FirstName;
        }

        private static void TestOut()
        {
            string first = "Raj";
            var last = "Thomas";
            string FirstName = GetNameWithOutParameter(out first, out last);

            Console.WriteLine(FirstName + "  -- " + last);
        }
        #endregion

        #region Tuple
        private static Tuple<string, string> GetNameWithTuple(string FirstName, string LastName)
        {
            FirstName = "Raj Rajesh";
            LastName = "Albert Einstein";
            var tuple = new Tuple<string, string>(FirstName, LastName);
            return tuple;
        }
        private static void TestTuple()
        {
            var tupleResult = GetNameWithTuple("Raj", "Thomas");
            Console.WriteLine(tupleResult.Item1 + "  -- " + tupleResult.Item2);
            string ver = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
            Console.WriteLine(ver);

        }

        /// <summary>
        /// Now that C# 7 has been released, you can use the new included Tuples syntax
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="CodeName"></param>
        /// <returns></returns>
        //private static (string, string, string) GetNameWithNewTuple(string FirstName, string LastName, string CodeName)
        //{
        //    FirstName = "Raj Rajesh";
        //    LastName = "Albert Einstein";
        //    CodeName = "JabbaWockeez";

        //    return (FirstName, LastName, CodeName);
        //}

        #endregion
    }
}

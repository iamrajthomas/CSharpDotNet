using System;

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
        /// <summary>
        /// Ref has to be initialized
        /// Out is not required to be initialized but The out parameter must be assigned to before control leaves the current method
        /// </summary>
        private static void TestRef()
        {
            string first = "Raj"; //initialized to avoid CE
            string last = "Thomas"; //initialized to avoid CE
            //string first; // Compile Time Error
            //string last; // Compile Time Error
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
            FirstName = "Albert"; // ERROR: The out parameter 'FirstName' must be assigned to before control leaves the current method
            LastName = "Einstein"; // ERROR: The out parameter 'LastName' must be assigned to before control leaves the current method
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// Ref has to be initialized
        /// Out is not required to be initialized but The out parameter must be assigned to before control leaves the current method
        /// </summary>
        private static void TestOut()
        {
            //string first = "Raj";
            //string last = "Thomas";
            string first;
            string last;
            string FirstName = GetNameWithOutParameter(out first, out last);

            Console.WriteLine(FirstName + "  -- " + last);
        }
        #endregion

        #region Tuple
        private static Tuple<string, string> GetNameWithTuple(string FirstName, string LastName)
        {
            FirstName = "Albert";
            LastName = "Einstein";
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

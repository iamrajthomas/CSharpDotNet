using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.NullableTypesTopic
{
    class TestNullableTypes
    {
        static void Main()
        {
            TestNullableDataTypes();
        }

        private static void TestNullableDataTypes()
        {
            // Nullable is a generic structure and only accepts structure as constraints
            Nullable<int> i = null; //Approach - 1
            int? j = null; //Approach - 2

            //Nullable<string> str = null; //CE

        }
    }
}

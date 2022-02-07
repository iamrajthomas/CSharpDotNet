using System;

namespace CSharpDotNet.ExtensionMethodTopic
{
    class TestExtension
    {
        /// <summary>
        /// Test Extension Method For LegacyApplication i.e. Class Type
        /// </summary>
        static void TestExtensionMethodForLegacyApplication()
        {
            LegacyApplication legacyApplication = new LegacyApplication();
            legacyApplication.Test1();
            legacyApplication.Test2();
            legacyApplication.Test3();

            var result = legacyApplication.Test4("Some Random Token");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Test Extension Method For Structure Type Int32
        /// </summary>
        static void TestExtensionMethodForStructureType()
        {
            int i = 5;
            var result = i.Factorial();
            Console.WriteLine($"Factorial of {i} is {result}");

            i = 10;
            result = i.Factorial();
            Console.WriteLine($"Factorial of {i} is {result}");
        }

        /// <summary>
        /// Test Extension Method For Sealed Class Type String
        /// </summary>
        static void TestExtensionMethodForSealedClassType()
        {
            string str = "heLlO wOrLd hOW aRe yOu";
            string result = str.ToProper();
            Console.WriteLine(result);

            str = "gOOd mORniIng. yOU haVE a gOOd dAy.";
            result = str.ToProper();
            Console.WriteLine(result);
        }

        static void Main()
        {
            TestExtensionMethodForLegacyApplication();
            Console.WriteLine("===========================================================");
            TestExtensionMethodForStructureType();
            Console.WriteLine("===========================================================");
            TestExtensionMethodForSealedClassType();

            Console.ReadLine();

        }
    }
}



#region Sequence
//1. TestExtension
//2. LegacyApplication
//3. ExtensionStatic
#endregion
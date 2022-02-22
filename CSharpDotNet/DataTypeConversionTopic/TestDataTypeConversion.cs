using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DataTypeConversionTopic
{
    class TestDataTypeConversion
    {
        static void Main()
        {
            Test1();
            Console.ReadLine();
        }

        static void Test1()
        {
            string i = null;

            //Console.WriteLine(i.ToString());
            Console.WriteLine(Convert.ToString(i));

            //IEnumerable --GetEnumerator()
            //ICollection --Count
            //IList --Insert() and RemoveAt()
            //IDictionary--Add() and Remove()
        }
    }
}

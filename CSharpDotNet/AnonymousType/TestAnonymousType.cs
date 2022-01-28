using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AnonymousType
{
    public class TestAnonymousType
    {
        public static void Invoke()
        {
            var AnonumousType = new
            {
                FirstName = "Rajesh",
                LastName = "Thomas"
            };

            Console.WriteLine("FirstName: " + AnonumousType.FirstName);
            Console.WriteLine("LastName: " + AnonumousType.LastName);
            Console.WriteLine("DataType: " + AnonumousType.GetType());
            Console.WriteLine("DataType with GetType() : " + AnonumousType.GetType());

            Console.WriteLine("nameof(AnonumousType) : " + nameof(AnonumousType));
            Console.WriteLine("nameof(AnonumousType.FirstName) : " + nameof(AnonumousType.FirstName));

        }
    }
}

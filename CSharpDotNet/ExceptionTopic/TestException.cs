using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.ExceptionTopic
{
    class TestException
    {
        static void Main()
        {
            TestMyException();

            Console.ReadLine();
        }

        private static void TestMyException()
        {
            try
            {
                Console.WriteLine("TestMyException: TRY");
                int x = 1;
                int y = 0;
                int z = x / y;
                Console.WriteLine("TestMyException: TRY END");
            }
            catch (Exception)
            {
                Console.WriteLine("TestMyException: CATCH");

                try
                {
                    int x = 1;
                    int y = 0;
                    int z = x / y;
                }
                catch (Exception)
                {
                    int x = 1;
                    int y = 0;
                    int z = x / y;
                    Console.WriteLine("TestMyException: INNER CATCH");
                    //throw;
                }
                //throw;
                Console.WriteLine("TestMyException: CATCH END");
            }
            finally
            {
                Console.WriteLine("TestMyException: FINALLY");
                int x = 1;
                int y = 0;
                int z = x / y;
                Console.WriteLine("TestMyException: FINALLY END");
            }
        }


    }
}

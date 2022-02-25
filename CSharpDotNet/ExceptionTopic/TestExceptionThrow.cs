using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.ExceptionTopic
{
    class TestExceptionThrow
    {
        static void Main()
        {
            Method1();

            Console.ReadLine();
        }
        static void Method1()
        {
            try
            {
                Method2();

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private static void Method2()
        {
            try
            {
                Method3();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private static void Method3()
        {
            throw new Exception();
        }
    }
    
}

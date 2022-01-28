using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.DesignPattern.SingletonPattern
{
    public class TestSingleton
    {
        public static void Invoke()
        {
            Singleton Instance1 = Singleton.GetInstance();
            Singleton Instance2 = Singleton.GetInstance();

            if (Instance1 == Instance2)
            {
                Console.WriteLine("INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("INSTANCE NOT EQUAL");
            }

            Console.WriteLine("===================================================================================");

            Singleton2 singleton2Instance1 = Singleton2.GetInstance;
            Singleton2 singleton2Instance2 = Singleton2.GetInstance;

            if (singleton2Instance1 == singleton2Instance2)
            {
                Console.WriteLine("INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("INSTANCE NOT EQUAL");
            }

            Console.WriteLine("===================================================================================");

            Singleton3 singleton3Instance1 = Singleton3.GetInstance;
            Singleton3 singleton3Instance2 = Singleton3.GetInstance;

            if (singleton3Instance1 == singleton3Instance2)
            {
                Console.WriteLine("INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("INSTANCE NOT EQUAL");
            }

        }



    }
}

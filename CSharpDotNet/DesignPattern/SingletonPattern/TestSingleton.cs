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
                Console.WriteLine("Singleton INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("Singleton INSTANCE NOT EQUAL");
            }

            Console.WriteLine("===================================================================================");

            Singleton2 singleton2Instance1 = Singleton2.GetInstance;
            Singleton2 singleton2Instance2 = Singleton2.GetInstance;

            if (singleton2Instance1 == singleton2Instance2)
            {
                Console.WriteLine("Singleton2 INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("Singleton2 INSTANCE NOT EQUAL");
            }

            Console.WriteLine("===================================================================================");

            Singleton3 singleton3Instance1 = Singleton3.GetInstance;
            Singleton3 singleton3Instance2 = Singleton3.GetInstance;

            if (singleton3Instance1 == singleton3Instance2)
            {
                Console.WriteLine("Singleton3 INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("Singleton3 INSTANCE NOT EQUAL");
            }

            Console.WriteLine("===================================================================================");

            Singleton5 singleton5Instance1 = Singleton5.GetInstance;
            Singleton5 singleton5Instance2 = Singleton5.GetInstance;
            if (singleton5Instance1 == singleton5Instance2)
            {
                Console.WriteLine("Singleton5 INSTANCE EQUAL");
            }
            else
            {
                Console.WriteLine("Singleton5 INSTANCE NOT EQUAL");
            }
        }


        static void Main()
        {
            Invoke();

        }



    }
}

#region Sequence
//1. TestSingleton
//2. Singleton1
//3. Singleton2
//4. Singleton3
//5. Singleton4
//5. Singleton5
#endregion
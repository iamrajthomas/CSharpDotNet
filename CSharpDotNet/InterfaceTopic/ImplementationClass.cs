using System;

namespace CSharpDotNet.InterfaceTopic
{
    interface ITestInterface1
    {
        void Add(int x, int y);
    }

    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int x, int y);
    }

    class ImplementationClass : ITestInterface2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Add: {0}", x + y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub: {0}", x - y);
        }


        static void Main()
        {
            ImplementationClass classInstance = new ImplementationClass();
            classInstance.Add(100, 50);
            classInstance.Sub(100, 50);

            ITestInterface1 interface1Reference = classInstance;
            interface1Reference.Add(100, 50);


            ITestInterface2 interface2Reference = classInstance;
            interface2Reference.Add(100, 50);
            interface2Reference.Sub(100, 50);



            Console.ReadLine();
        }
    }
}

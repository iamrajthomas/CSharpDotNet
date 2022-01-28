using System;

namespace CSharpDotNet.InheritanceTopic
{
    class Class4 : Class3
    {
        public Class4() : base(100)
        {
            Console.WriteLine("Class 3 constructor invoked");
        }

        public Class4(int value) : base(value)
        {
            Console.WriteLine("Class 3 constructor invoked");
        }

        static void Main()
        {
            Class4 childInstance = new Class4(); //hard-coded 100 will be passed to parent constructor
            Class4 childInstance2 = new Class4(50); //non-hard-coded 50 will be passed to parent constructor
            Console.ReadLine();
        }
    }
}

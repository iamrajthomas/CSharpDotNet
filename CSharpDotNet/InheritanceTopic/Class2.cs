using System;

namespace CSharpDotNet.InheritanceTopic
{
    class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Class 2 constructor invoked");
        }

        public void Test3()
        {
            Console.WriteLine("Method 3");
        }

        public void Test4()
        {
            Console.WriteLine("Method 4");
        }

        static void Main()
        {
            Class1 parentInstance = new Class1();
            parentInstance.Test1();
            parentInstance.Test2();
            //parentInstance.Test3(); //Wont appear at all
            //parentInstance.Test4(); //Wont appear at all

            Class2 childInstnace = new Class2();
            childInstnace.Test1();
            childInstnace.Test2();
            childInstnace.Test3();
            childInstnace.Test4();

            Class1 parentReference = childInstnace;
            parentReference.Test1();
            parentReference.Test2();
            //parentReference.Test3(); //Wont appear at all
            //parentReference.Test4(); //Wont appear at all
        }
    }
}

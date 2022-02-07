using System;

namespace CSharpDotNet.PolymorphismTopic.Shadowing
{
    class Child : Parent
    {
        /// <summary>
        /// Overidden Method from Parent
        /// </summary>
        public override void Test1()
        {
            Console.WriteLine("Test 1 Child. This is overidden method from Parent.");
        }

        /// <summary>
        /// Shadowed Method from Parent
        /// </summary>
        public new void Test2()
        {
            Console.WriteLine("Test 2 Child. This is shadowed method from Parent.");
        }

        static void Main()
        {
            Child childInstnace = new Child();
            childInstnace.Test1();
            childInstnace.Test2();

            Console.WriteLine("============================================================");

            Parent parentInstance = new Parent();
            parentInstance.Test1();
            parentInstance.Test2();

            Console.WriteLine("============================================================");

            Parent parentReference = childInstnace;
            parentReference.Test1(); //Invokes child Test1 because this is overriden method, so it is not pure child class method and considers as parent method only.
            parentReference.Test2(); //Invokes parent Test2 because this is shadowed method, so it is pure child class method and considers as child method only.


            //Child childRef = parentInstance; // This is not possible anyway!!
            Child childRef = (Child)parentReference; // This is possible with explicit conversion!!
            childRef.Test1();
            childRef.Test2();

            Console.ReadLine();
        }
    }
}

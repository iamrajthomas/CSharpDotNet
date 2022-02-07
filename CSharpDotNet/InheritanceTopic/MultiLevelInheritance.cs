using System;

namespace CSharpDotNet.InheritanceTopic
{
    class ClassA
    {
        public void Method1()
        {
            Console.WriteLine("A: Method1");
        }
    }

    class ClassB : ClassA
    {
        public void Method2()
        {
            Console.WriteLine("B: Method2");
        }
    }

    class ClassC : ClassB
    {
        public void Method3()
        {
            Console.WriteLine("C: Method3");
        }
    }
    class MultiLevelInheritance
    {
        static void Main()
        {
            #region Scenario - 1

            ClassA classA = new ClassA();
            classA.Method1();

            ClassB classB = new ClassB();
            classB.Method1();
            classB.Method2();

            ClassC classC = new ClassC();
            classC.Method1();
            classC.Method2();
            classC.Method3();

            #endregion

            //=================================================================

            #region Scenario - 2

            // ParentClass ParentRef = new ChildClassConstructor(); // Possible
            // ChildClass ParentRef = new ParentClassConstructor(); // Not Possible with implicit conversion

            ClassA classARef = new ClassB();
            classARef.Method1();

            ClassA classARef2 = new ClassC();
            classARef2.Method1();

            ClassB classBRef = new ClassC();
            classBRef.Method1();
            classBRef.Method2();

            #endregion

            //=================================================================

            #region Scenario - 3

            // ChildClass ChidRef = (ChildClass)new ParentClassConstructor(); // Not Possible with explicit conversion
            // Even if the conversion is done and no compilation error, it will fail at run-time
            // Reason is: When a parent class constructor is called for creating a child ref, the parent ctor will not have any access to child class ctor
            // As the child ctor is not called, no members get initialized at child class. So it will fail at run-time.
            // Bottom to Top access is possible but not reverse!!

            // Error Message: Unable to cast object of type 'CSharpDotNet.InheritanceTopic.ClassA' to type 'CSharpDotNet.InheritanceTopic.ClassB'.
            //ClassB classBRef2 = (ClassB)new ClassA();
            //classBRef2.Method1();
            //classBRef2.Method2();

            // Error Message: Unable to cast object of type 'CSharpDotNet.InheritanceTopic.ClassB' to type 'CSharpDotNet.InheritanceTopic.ClassC'.
            //ClassC classCRef = (ClassC)new ClassB();
            //classCRef.Method1();
            //classCRef.Method2();
            //classCRef.Method3();

            // Error Message: Unable to cast object of type 'CSharpDotNet.InheritanceTopic.ClassA' to type 'CSharpDotNet.InheritanceTopic.ClassC'.
            //ClassC classCRef2 = (ClassC)new ClassA();
            //classCRef2.Method1();
            //classCRef2.Method2();
            //classCRef2.Method3();

            #endregion

            Console.ReadLine();
        }


    }

}

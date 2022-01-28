using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.InheritanceTopic
{
    public class TestInheritance1
    {
        public static void Invoke()
        {
            TopClass topClass = new TopClass();
            topClass.SomeWeirdFunction();

            MiddleClass middleClass = new MiddleClass();
            middleClass.SomeWeirdFunction();

            BottomClass bottomClass = new BottomClass();
            bottomClass.SomeWeirdFunction();
        }
    }

    public class TopClass
    {
        private string ThisIsOnlyAccessibleForTopClass { get; set; } //This is private
        private string ThisIsOnlyAccessibleForTopClassAndMiddleClass { get; set; } //This is private
        protected virtual string OnlyMiddleClass()
        {
            return ThisIsOnlyAccessibleForTopClassAndMiddleClass = "As this is a MiddleClass class, I am accessible here.. That is good!";
        }

        public virtual void SomeWeirdFunction()
        {
            ThisIsOnlyAccessibleForTopClass = "I can access this here as it is grand father's private member!";
        }
    }

    public class MiddleClass : TopClass
    {
        public override void SomeWeirdFunction()
        {
            Console.WriteLine(base.OnlyMiddleClass()); // As this is a MiddleClass class, I am accessible here.. That is good!
            Console.WriteLine(OnlyMiddleClass()); // Prohibited
        }

        protected override sealed string OnlyMiddleClass() { return null; }
    }

    public class BottomClass : MiddleClass
    {
        public override void SomeWeirdFunction()
        {
            Console.WriteLine(base.OnlyMiddleClass()); // Prohibited
            Console.WriteLine(OnlyMiddleClass()); // Prohibited
        }
    }

}

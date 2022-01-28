using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.InheritanceTopic
{
    public class TestInheritance2
    {
        public static void Invoke()
        {
            TopLayerClass obj1 = new TopLayerClass();
            Console.WriteLine(obj1.AccessibleFromEverywhere);
            obj1.RandomePublicFunction();

            TopLayerClass.MiddleLayerClass obj2 = new TopLayerClass.MiddleLayerClass();
            Console.WriteLine(obj2.AccessibleFromEverywhere);
            obj2.RandomePublicFunction();

            BottomLayerClass obj3 = new BottomLayerClass();
            Console.WriteLine(obj3.AccessibleFromEverywhere);
            obj3.RandomePublicFunction();

            Console.ReadLine();
        }
    }

    public class TopLayerClass
    {
        private string ThisIsOnlyAccessibleForTopClass { get; set; }
        private string ThisIsOnlyAccessibleForTopClassAndMiddleClass { get; set; } // We want this to be accessible only by the MiddleLayerClass 
        public string AccessibleFromEverywhere { get; set; } // this is good as it is public so this accessible from everywhere

        public virtual void RandomePublicFunction()
        {
            ThisIsOnlyAccessibleForTopClass = "I can access this here as it is grand father's private member!";
        }

        public class MiddleLayerClass : TopLayerClass
        {
            public override void RandomePublicFunction()
            {
                base.ThisIsOnlyAccessibleForTopClassAndMiddleClass = "As this is a MiddleClass class, I am accessible here.. That is good!";
            }
        }

    }

    public class BottomLayerClass : TopLayerClass.MiddleLayerClass
    {
        public override void RandomePublicFunction()
        {
            //base.ThisIsOnlyAccessibleForTopClassAndMiddleClass = "I don't want this to be accessible here!"; // Compilation Error
        }
    }

}

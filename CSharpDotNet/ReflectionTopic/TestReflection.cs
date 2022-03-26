using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.ReflectionTopic
{
    class TestReflection
    {
        public static void Main()
        {
            Console.WriteLine("Invoking by conventional approach");

            MyClass myClass = new MyClass();
            myClass.PromptMessage("Hello");

            Console.WriteLine("Invoking by reflection approach");

            // create the Type object
            Type type = typeof(MyClass);

            // create instnace of type
            object obj = Activator.CreateInstance(type);
            (obj as MyClass).PromptMessage("Hello From Reflection");

            // FieldInfo[] fi = type.GetFields(BindingFlags.Default | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public); // fields
            // MethodInfo[] mi = type.GetMethods(BindingFlags.Default | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            // iterate through all the method members

            // fields
            FieldInfo[] fi = type.GetFields(); 

            // iterate through all the method members
            MethodInfo[] mi = type.GetMethods();

            PropertyInfo[] props = type.GetProperties();

            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m);
            }

            // iterate through all the field members
            foreach (FieldInfo f in fi)
            {
                Console.WriteLine(f);
            }

            // iterate through all the field members
            foreach (PropertyInfo p in props)
            {
                Console.WriteLine(p);
            }


            Console.ReadLine();
        }
    }

    class MyClass
    {
        public static int x = 0;
        public void PromptMessage(string param1)
        {
            Console.WriteLine("MyClass... " + param1);
        }


        private void promptPrivate(string param1, string param2)
        {
            Console.WriteLine("MyClass... " + param1);
        }

        public static void prompt2()
        {
            Console.WriteLine("Here is a message from prompt2.");
        }
    }
}

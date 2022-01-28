using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.CodeRefactor
{
    // client program
    public class Refactor1
    {
        public static void Invoke()
        {
            ClassA refA = new ClassA();
        }
    }

    // Is there a way to modify ClassA so that you can you call the constructor with parameters, 
    // when the Main method is called, without creating any other new instances of the ClassA?
    class ClassA
    {
        // Adding : this(10) to the constructor will do the job.
        public ClassA() : this(10)
        { }

        public ClassA(int pValue) { }
    }
}

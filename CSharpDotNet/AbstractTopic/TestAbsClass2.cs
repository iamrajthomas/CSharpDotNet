using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AbstractTopic
{
    abstract class TestAbsClass2 : TestAbsClass1
    {
        // Dont need to override any abstract members from the base abstract class. i.e. No Compilation Error
        // The overide of method will be done at the child level of this abstract class
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.AttributeTopic
{
    class HelpMessageAttribute : Attribute
    {
        public string HelpText { get; set; }
        public bool IsError { get; set; }

        public HelpMessageAttribute() { }

        public HelpMessageAttribute(string helpText, bool isError = false)
        {
            HelpText = helpText;
            IsError = isError;
        } 
    }
}

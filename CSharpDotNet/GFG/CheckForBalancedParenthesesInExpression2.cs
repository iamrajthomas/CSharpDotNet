using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG
{
    public class CheckForBalancedParenthesesInExpression2
    {
        //static string SampleInput = "[][][][]"; 
        static string SampleInput = "[[]][]()";
        //static string SampleInput = "]["; //code breaks here 
        //static int count = 0;
        //static int i = 0;
        //static int j = -1;
        public static void Invoke()
        {
            var IsValid = IsValidExpression();
            if (IsValid)
            {
                Console.Write("This is valid");
            }
            else
            {
                Console.Write("This is not valid");
            }
        }

        private static bool IsValidExpression()
        {
            if (SampleInput.Length == 0)
                return true;

            if (SampleInput.Length % 2 != 0)
                return false;

            if (SampleInput.StartsWith("]") || SampleInput.StartsWith(")") || SampleInput.StartsWith("}"))
                return false;

            int NumberOfOpeningSquareBracket = 0;
            int NumberOfClosingSquareBracket = 0;

            int NumberOfOpeningMoonBracket = 0;
            int NumberOfClosingMoonBracket = 0;

            int NumberOfOpeningCurlyBracket = 0;
            int NumberOfClosingCurlyBracket = 0;

            for (int i = 0; i < SampleInput.Length; i++)
            {
                switch (SampleInput[i].ToString())
                {
                    case "[": NumberOfOpeningSquareBracket++;
                        break;

                    case "]": NumberOfClosingSquareBracket++;
                        break;

                    case "(": NumberOfOpeningMoonBracket++;
                        break;

                    case ")": NumberOfClosingMoonBracket++;
                        break;

                    case "{": NumberOfOpeningCurlyBracket++;
                        break;

                    case "}":  NumberOfClosingCurlyBracket++;
                        break;

                    default:
                        break;
                }
            }

            if((NumberOfOpeningSquareBracket != NumberOfClosingSquareBracket) ||
                (NumberOfOpeningMoonBracket != NumberOfClosingMoonBracket) ||
                (NumberOfOpeningCurlyBracket != NumberOfClosingCurlyBracket))
            {
                return false;
            }

            return true;
        }
    }
}

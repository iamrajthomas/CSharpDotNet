using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.GFG
{
    public class CheckForBalancedParenthesesInExpression
    {
        static string s = "[{[{]]}}[]()";
        //static string s = "]["; //code breaks here 
        static int count = 0;
        static int i = 0;
        static int j = -1;

        public static void Invoke()
        {
            var IsValid = IsValidExpression();
            if (IsValid)
            {
                Console.Write("No");
            }
            else
            {
                Console.Write("Yes");
            }
        }

        static bool IsValidExpression()
        {

            // Empty string is considered balanced
            if (s.Length == 0)
                return true;

            else
            {
                int result;
                while (i < s.Length)
                {
                    char temp = s[i];
                    if (temp == '}')
                    {
                        result = Helper('{');
                        if (result == 0)
                        {
                            return false;
                        }
                    }

                    else if (temp == ')')
                    {
                        result = Helper('(');
                        if (result == 0)
                        {
                            return false;
                        }
                    }

                    else if (temp == ']')
                    {
                        result = Helper('[');
                        if (result == 0)
                        {
                            return false;
                        }
                    }

                    else
                    {
                        j = i;
                        i++;
                        count++;
                    }
                }

                // count != 0 indicates unbalanced 
                // parentheses this check is required 
                // to handle cases where count of opening
                // brackets > closing brackets 
                if (count != 0)
                    return false;

                return true;
            }
        }

        // This helper function is called whenever
        // closing bracket is encountered. Hence 
        // count is decremented j and i points to
        // opening and closing brackets to be matched 
        // respectively. If brackets at i and j is a match
        // replace them with "#" character and decrement j
        // to point next opening bracket to * be matched
        // Similarly, increment i to point to next closing
        // bracket to be matched. If j is out of bound or
        // brackets did not match return 0
        static int Helper(char tocom)
        {
            count--;
            char temp = s[j];

            if (j > -1 && temp == tocom)
            {
                s = s.Replace(s[i], '#');
                s = s.Replace(s[j], '#');

                temp = s[j];
                while (j >= 0 && temp == '#')
                    j--;

                i++;
                return 1;
            }
            else
                return 0;
        }


    }
}

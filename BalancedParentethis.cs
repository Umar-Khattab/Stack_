using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_
{
    internal class BalancedParentethis
    {
        public static bool IsValid(string Ex)
        {
            Stack<char> s1 = new Stack<char>();
            foreach (char c in Ex)
            {
                if (c == '(' || c == '[' || c == '{' || c == '<')
                {
                    s1.Push(c);
                }
                //{}
                else
                {
                    if (s1.Count == 0) { return false; }
                    var x = s1.Pop();
                    if (x == '(' && c != ')')
                        return false;
                    else if (x == '{' && c != '}')
                        return false;
                    else if (x == '[' && c != ']')
                        return false;
                    else if (x == '<' && c != '>')
                        return false;
                }
            }
            if (s1.Count != 0)
                return false;
            return true;
        }
    }
}

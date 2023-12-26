using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_
{
    internal class ReversingWord
    {
        public string RevString(string word)
        {
            StackArray s2 = new StackArray(word.Length);
            foreach (char c in word)
            {
                s2.Push(c);
            }
            string x = "";
            foreach (char c in word)
            {
                x += s2.Pop();
            }
            return x;
        }
    }
}

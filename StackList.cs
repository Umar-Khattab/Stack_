using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_
{
    internal class StackList
    {
        public class Node
        {
            public int Data;
            public Node Next;
        }
        Node Top;
        public bool IsEmpty()
        {
            if (Top == null) return true;
            else return false;
        }
        public int Size()
        {
            if (IsEmpty()) return 0;
            int Counter = 0;
            Node p = Top;
            while (p != null)
            {
                Counter++;
                p = p.Next;
            }
            return Counter;
        }
        public void Push(int value)
        {
            Node temp = new Node();
            temp.Data = value;
            if (IsEmpty())
            {
                Top = temp;
                return;
            }
            temp.Next = Top;
            Top = temp;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;
            }
            int x = Top.Data;
            Top = Top.Next;
            return x;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;
            }
            return Top.Data;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Node p = Top;
            while (p != null)
            {
                Console.WriteLine($"");
                p = p.Next;
            }
        }
    }
}

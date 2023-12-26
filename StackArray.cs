using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_
{
    internal class StackArray
    {
        int top;
        int[] Data;
        public StackArray(int size)
        {
            Data = new int[size];
            top = -1;
        }
        public bool IsEmpty()
        {
            if (top == -1) return true;
            else return false;
        }
        public int Size()
        {
            return top + 1;
        }
        public bool IsFull()
        {
            if (top == Data.Length - 1) return true;
            else return false;
        }
        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("stack over flow");
                return;
            }
            top += 1;
            Data[top] = value;
        }
        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;
            }
            x = top;
            top -= 1;
            return x;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;
            }
            return Data[top];
        }
        public void Display()
        {
            Console.WriteLine($"top = {top}");
            if (IsEmpty())
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(Data[i]);
            }
        }
    }
}

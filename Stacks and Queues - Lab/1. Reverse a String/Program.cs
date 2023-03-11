using System;
using System.Collections;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack stack = new Stack();

            foreach (char ch in input)
            {
                stack.Push(ch);
            }

            while(stack.Count > 0) 
            {
                Console.Write(stack.Pop());
            }
        }
    }
}

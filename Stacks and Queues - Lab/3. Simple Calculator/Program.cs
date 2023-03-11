using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if (symbol == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else if (symbol == "-")
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }

            }

            Console.WriteLine(stack.Pop());

        }
    }
}

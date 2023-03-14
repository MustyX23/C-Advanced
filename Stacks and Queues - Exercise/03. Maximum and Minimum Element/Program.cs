using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split(' ');
                string query = command[0];

                if (query == "1")
                {
                    int numberToPush = int.Parse(command[1]);
                    stack.Push(numberToPush);
                }
                else if (query == "2")
                {
                    stack.Pop();
                }
                else if (query == "3")
                {
                    Console.WriteLine(stack.Max());
                }
                else if (query == "4")
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}

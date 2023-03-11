using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Stack stack = new Stack(array);
            Stack<int> stack = new Stack<int>(array);

            string input;

            while ((input = Console.ReadLine()).ToLower() != "end")
            {
                string[]commandArgs = input.Split(' ');
                string action = commandArgs[0].ToLower();

                if (action == "add")
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    int secondNumber = int.Parse(commandArgs[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (action == "remove")
                {
                    int countToRemove = int.Parse(commandArgs[1]);
                    for (int i = 0; i < countToRemove; i++)
                    {
                        if (stack.Count < countToRemove)
                        {
                            continue;
                        }
                        stack.Pop();                       
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(array);

            int rackCapacity = int.Parse(Console.ReadLine());

            int racks = 1;
            int sum = 0;

            while (stack.Any())
            {
                if (sum + stack.Peek() <= rackCapacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}

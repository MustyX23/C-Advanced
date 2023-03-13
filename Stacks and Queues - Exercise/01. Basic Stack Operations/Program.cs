using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int N = array[0];
            int S = array[1];
            int X = array[2];
           
            int[]workPlace = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(workPlace);

            for (int i = 0; i < S; i++)
            {
                stack.Pop();               
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int smallestNumber = stack.AsQueryable().Min();
                Console.WriteLine(smallestNumber);
            }

        }
    }
}

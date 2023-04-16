using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();           

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "add")
                {
                    nums = nums.Select(n => n + 1).ToList();
                }
                else if (input == "multiply")
                {
                    nums = nums.Select(n => n * 2).ToList();
                }
                else if (input == "subtract")
                {
                    nums = nums.Select(n => n - 1).ToList();
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(' ', nums));
                }
                else
                {
                    break;
                }
            }

        }
    }
}

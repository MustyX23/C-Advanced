using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            nums.Reverse();
            int divisible = int.Parse(Console.ReadLine());

            nums = nums.Where(x => x % divisible != 0).ToList();

            Console.WriteLine(String.Join(' ', nums));
        }
    }
}

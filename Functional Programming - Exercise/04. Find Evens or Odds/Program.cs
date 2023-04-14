using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int start = nums[0];
            int end = nums[1];

            string action = Console.ReadLine();
            Predicate<int> filter;
            Action<string> print = Console.Write;

            if (action == "even")
            {
                filter = x => x % 2 == 0;
            }
            else
            {
                filter = x => x % 2 != 0;
            }

            for (int i = start; i <= end; i++)
            {
                if (filter(i))
                {
                    print(i + " ");
                }
            }

        }
    }
}

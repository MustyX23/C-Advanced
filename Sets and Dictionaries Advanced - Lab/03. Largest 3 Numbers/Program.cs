using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sortedNums = nums.OrderByDescending(x => x).Take(3).ToArray();

            for (int i = 0; i < sortedNums.Length; i++)
            {
                Console.Write(sortedNums[i] + " ");
            }
        }
    }
}

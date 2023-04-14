using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Func<int[], int> findSmallestNum = n => n.Min();

            int smallestNum = findSmallestNum(nums);

            Console.WriteLine(smallestNum);
        }
    }
}

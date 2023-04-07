using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> pairs = new Dictionary<double, int>();

            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                

                if (!pairs.ContainsKey(nums[i]))
                {
                    pairs.Add(nums[i], count = 1);
                }
                else
                {
                    pairs[nums[i]]++;
                }
            }

            foreach (var num in pairs)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}

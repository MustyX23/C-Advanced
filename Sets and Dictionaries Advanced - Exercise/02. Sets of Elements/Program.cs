using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> integers = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];

            for (int i = 0; i < n + m; i++)
            {
                int ints = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    integers.Add(ints);
                }
                else
                {
                    result.Add(ints);
                }              
            }

            integers.IntersectWith(result);
            
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}

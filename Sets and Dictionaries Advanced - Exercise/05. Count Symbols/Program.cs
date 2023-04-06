using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> map = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            char[] chars = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (!map.ContainsKey(chars[i]))
                {
                    map.Add(chars[i], 1);
                }
                else
                {
                    map[chars[i]]++;
                }
            }

            foreach (var c in map)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (string item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }

                    wardrobe[color][item]++;
                }
            }

            string[] search = Console.ReadLine().Split(" ");
            string searchColor = search[0];
            string searchItem = search[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> colorEntry in wardrobe)
            {
                string color = colorEntry.Key;
                Dictionary<string, int> clothes = colorEntry.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (KeyValuePair<string, int> itemEntry in clothes)
                {
                    string item = itemEntry.Key;
                    int count = itemEntry.Value;

                    if (color == searchColor && item == searchItem)
                    {
                        Console.WriteLine($"* {item} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item} - {count}");
                    }
                }
            }
        }
    }
}

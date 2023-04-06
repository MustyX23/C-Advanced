using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<List<string>, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Blue -> dress,jeans,hat
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<List<string>, int>();
                }

                if (!wardrobe[color].ContainsKey(new List<string>(clothes)))
                {
                    wardrobe[color][new List<string>(clothes)] = 1;
                }
                else
                {
                    wardrobe[color][new List<string>(clothes)]++;
                }              
            }

            string[] searchingItem = Console.ReadLine().Split(' ');

            string colorOfItem = searchingItem[0];
            string itemToSearch = searchingItem[1];

            foreach (var item in wardrobe)
            {
                string color = item.Key;
                Dictionary<List<string>, int> clothes = item.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var clothe in clothes)
                {
                    List<string> outfit = clothe.Key;
                    int count = clothe.Value;

                    string clothesString = string.Join(", ", outfit);

                    if (color == colorOfItem && outfit.Contains(itemToSearch))
                    {
                        Console.WriteLine($"* {clothesString} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothesString} - {count}");
                    }
                }
            }
        }
    }
}

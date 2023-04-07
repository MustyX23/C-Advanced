using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;

namespace _00._Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}: ");
                var country = continent.Value;
                foreach (var countries in country)
                {
                    Console.WriteLine($" {countries.Key} -> " + string.Join(", ", countries.Value));
                }
            }
        }
    }
}

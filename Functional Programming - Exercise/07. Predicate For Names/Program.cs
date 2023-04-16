using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ")
                .Where(name => name.Length <= n)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));

        }
    }
}

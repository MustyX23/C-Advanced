using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            Action<string> print = Console.WriteLine;

            PrintNamesWithPrefix(names, "Sir", print);
        }

        static void PrintNamesWithPrefix(string[]names, string prefix, Action<string> print)
        {
            foreach (var name in names)
            {
                print($"{prefix} {name}");
            }             
        }
    }
}

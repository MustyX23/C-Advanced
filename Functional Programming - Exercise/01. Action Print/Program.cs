using System;
using System.Collections.Generic;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]stringCollection = Console.ReadLine().Split(' ');

            Action<string> print = Console.WriteLine;

            PrintNames(stringCollection, print);
        }

        static void PrintNames(string[] collection, Action<string> printAction)
        {
            foreach (string item in collection)
            {
                printAction(item);
            }                
        }
    }
}

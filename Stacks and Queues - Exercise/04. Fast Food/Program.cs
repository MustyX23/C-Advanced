using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> quantityOfOrder = new Queue<int>(array);

            Console.WriteLine(quantityOfOrder.Max());

            int savedLength = quantityOfOrder.Count;

            for (int i = 0; i < savedLength; i++)
            {
                int currentNumber = quantityOfOrder.Dequeue();

                if (currentNumber > quantity)
                {
                    Console.WriteLine($"Orders left: {currentNumber}");
                    return;
                }
                quantity -= currentNumber;
            }

            Console.WriteLine("Orders complete");
        }
    }
}

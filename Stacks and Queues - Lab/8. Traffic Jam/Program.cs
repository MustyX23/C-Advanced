using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string input;
            int counter = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (cars.Count <= n)
                    {
                        n = cars.Count;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        counter++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}

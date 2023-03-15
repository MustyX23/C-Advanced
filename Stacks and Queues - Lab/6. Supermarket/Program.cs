using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                if (input == "Paid")
                {
                    int savedQueue = queue.Count;
                    for (int i = 0; i < savedQueue; i++)
                    {
                        Console.WriteLine(queue.Dequeue()); 
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}

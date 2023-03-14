using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the initial sequence of songs
            string[] songs = Console.ReadLine().Split(", ");

            // Create a queue to hold the songs
            Queue<string> queue = new Queue<string>(songs);

            // Process commands until the queue is empty
            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    // Remove the first song from the queue
                    string song = queue.Dequeue();
                }
                else if (command.StartsWith("Add "))
                {
                    string song = command.Substring(4);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    // Print all songs in the queue
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}

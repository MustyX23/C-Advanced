using System;
using System.Collections.Generic;
using System.Linq;

namespace RubberDucks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> times = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Dictionary<string, int> ducks = new Dictionary<string, int>()
            {
                { "Darth Vader Ducky", 0 },
                { "Thor Ducky", 0 },
                { "Big Blue Rubber Ducky", 0 },
                { "Small Yellow Rubber Ducky", 0 }
            };
                

            while (times.Count != 0 && tasks.Count != 0)
            {
                int time = times.Dequeue();
                int task = tasks.Pop();

                int sum = time * task;

                if ((sum >= 0) && (sum <= 240))
                {
                    if ((sum >= 0) && (sum <= 60))
                    {
                        ducks["Darth Vader Ducky"]++;
                    }
                    else if ((sum >= 61) && (sum <= 120))
                    {
                        ducks["Thor Ducky"]++;
                    }
                    else if ((sum >= 121) && (sum <= 180))
                    {
                        ducks["Big Blue Rubber Ducky"]++;
                    }
                    else if ((sum >= 181) && (sum <= 240))
                    {
                        ducks["Small Yellow Rubber Ducky"]++;
                    }
                }
                else
                {
                    task -= 2;
                    tasks.Push(task);
                    times.Enqueue(time);
                }
            }

            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

            foreach (var duck in ducks)
            {
                Console.WriteLine($"{duck.Key}: {duck.Value}");
            }

        }
    }
}

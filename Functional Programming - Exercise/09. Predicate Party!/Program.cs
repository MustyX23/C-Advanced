using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ")
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "Party!")
            {
                string[] tokens = input.Split(' ');

                string action = tokens[0];
                string criteria = tokens[1];
                string givenString = tokens[2];               

                //...

                if (action == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        people.RemoveAll(p => p.StartsWith(givenString));
                    }
                    else if (criteria == "EndsWith")
                    {
                        people.RemoveAll(p => p.EndsWith(givenString));
                    }
                    else if (criteria == "Length")
                    {
                        int length = int.Parse(givenString);
                        people.RemoveAll(p => p.Length == length);
                    }
                }
                else if (action == "Double")
                {
                    List<string> doubledItems = new List<string>();

                    if (criteria == "StartsWith")
                    {
                        people.ForEach(item =>
                        {
                            if (item.StartsWith(givenString))
                            {
                                doubledItems.Add(item);
                            }
                        });
                    }
                    else if (criteria == "EndsWith")
                    {
                        people.ForEach(item =>
                        {
                            if (item.EndsWith(givenString))
                            {
                                doubledItems.Add(item);
                            }
                        });
                    }
                    else if (criteria == "Length")
                    {
                        int length = int.Parse(givenString);

                        people.ForEach(item =>
                        {
                            if (item.Length == length)
                            {
                                doubledItems.Add(item);
                            }
                        });
                    }

                    // Add doubled items to original list
                    people.AddRange(doubledItems);
                }
            }

            if (people.Count <= 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", people.OrderBy(x => x)));
                Console.Write(" are going to the party!");
            }
            
        }
    }
}

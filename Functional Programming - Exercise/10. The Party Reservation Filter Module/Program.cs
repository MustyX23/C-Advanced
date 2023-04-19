using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(' ')
                .ToList();

            Dictionary<string, Predicate<string>> filters = new();

            string command = string.Empty;

            while ((command = Console.ReadLine())!= "Print")
            {
                string[] tokens = command.Split(';', StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string filter = tokens[1];
                string parameter = tokens[2];

                if (action == "Add filter")
                {
                    filters.Add(filter + parameter, GetPredicate(filter, parameter));
                }
                else
                {
                    filters.Remove(filter + parameter);
                }
            }

            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", people));
        }

        static Predicate<string> GetPredicate (string filter, string parameter)
        {
            if (filter == "Starts with")
            {
                return p => p.StartsWith(parameter);
            }
            else if (filter == "Ends with")
            {
                return p => p.EndsWith(parameter);
            }
            else if (filter == "Contains")
            {
                return p => p.Contains(parameter);
            }
            else if (filter == "Length")
            {
                return p => p.Length == int.Parse(parameter);
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ")
                .ToList();
           
            Func<string, int, bool> filteringChars = (name, number) => 
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum += (int)name[i];
                }

                if (sum >= number)
                {
                    return true;
                }

                return false;
            };

            Func<List<string>, Func<string, int, bool>, string> filteringWords = (names, filter) =>
            {
                string word = string.Empty;

                for (int i = 0; i < names.Count; i++)
                {
                    if (filteringChars(names[i], n))
                    {
                        word = names[i];
                    }
                }

                return word;
            };

            string word = filteringWords(names, filteringChars);

            Console.WriteLine(word);
        }
    }
}

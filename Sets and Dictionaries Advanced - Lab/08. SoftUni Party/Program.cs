using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string input;

            while ((input = Console.ReadLine())!= "PARTY")
            {
                string reservationNums = input;
                guests.Add(reservationNums);
            }

            while((input = Console.ReadLine()) != "END")
            {
                string people = input;

                if (guests.Contains(people))
                {
                    guests.Remove(people);
                }
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                if (Char.IsDigit(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }

            foreach (var guest in guests)
            {
                if (Char.IsLetter(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}

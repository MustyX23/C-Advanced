using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person member = new Person(name, age);

                family.AddMember(member);                
            }

            List<Person> peopleOver30 = family.GetPersonOver30();

            foreach (var member in peopleOver30)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }

        }
    }
}

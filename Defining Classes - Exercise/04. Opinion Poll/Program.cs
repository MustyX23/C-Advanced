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
            List<Person> older = new List<Person>();
           
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                older.Add(new Person(name, age));
            }
            older = older.Where(person => person.Age > 30).OrderBy(person => person.Name).ToList();

            foreach (var person in older)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}

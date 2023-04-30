using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            Func<Person, bool> filter = p => true;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string name = input[0];
                int age = int.Parse(input[1]);
               
                Person person = new Person();
                person.Age = age;
                person.Name = name;
                people.Add(person);
            }

            string command = Console.ReadLine();
            int agePattern = int.Parse(Console.ReadLine());
            string format = Console.ReadLine(); // name/age/name age

            if (command == "older")
            {
                filter = p => p.Age >= agePattern;
            }
            else
            {
                filter = p => p.Age < agePattern;
            }

            var peopleFilter = people.Where(filter);

            Func<Person, string> print = p => p.Name + " " + p.Age;
            List<Person> filterPeople = people.Where(filter).ToList();
            if (format == "name")
            {
                print = p => p.Name;
            }
            else if (format == "age")
            {
                print = p => p.Age.ToString();
            }
            else
            {
                print = p => p.Name + " - " + p.Age;
            }

            List<string> printPeople = filterPeople.Select(print).ToList();
            
            foreach (var item in printPeople)
            {
                Console.WriteLine(item);
            }
        }        
    }
}

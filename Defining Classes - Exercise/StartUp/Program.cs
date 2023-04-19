using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                Person person = new Person();
                //Name	Age
                //Peter - 20
                //George - 18
                //Jose - 43
                person.Name = name;
                person.Age = age;

                people.Add(person);
            }

            //Use the type of people which is Person to cycle through the List<Person> people
            foreach (Person person in people)
            {
                //Print person's name and age...
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }    
}

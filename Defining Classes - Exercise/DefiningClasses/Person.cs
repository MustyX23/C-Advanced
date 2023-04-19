using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{

    public class Person
    {
        //public string Name { get; set; }
        //public int Age { get; set; }

        private string name;
        private int age;

        //The first should take no arguments
        //and produce a person with the name "No name" and age = 1.
        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        //The second should accept only an integer number for the age
        //and produce a person with the name "No name"
        //and age equal to the passed parameter.
        public Person(int age) :this()
        {
            Age = age;
        }

        //The third one should accept a string for the name
        //and an integer for the age
        //and should produce a person with the given name and age.
        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}

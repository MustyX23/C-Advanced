using System;
using System.Collections.Generic;

namespace GenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulate operations to a non-particular data type
            //Defined with Type Parameters - T

            //Most commonly used are generic collections:
            //Linked Lists, Hash tables, Stacks, Queues, Trees, etc
            List<string> listOfStrings = new List<string>() {"Fin", "Jake"};

            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Fin", 13));

            Stack<int> stacks = new Stack<int>();
            HashSet<int> set = new HashSet<int>();

            //Collections with multiple type parameters – Dictionary<T, V>
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        }
    }
    public class Student 
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}

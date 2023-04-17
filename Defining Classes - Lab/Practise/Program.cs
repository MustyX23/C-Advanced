using System;

namespace Practise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Mustafa",
                Age = 13,
                Gender = "male"
            };
            person.Introduce();
        }
    }
    class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}. I'm {Age} years old and I identify as {Gender}.");
            return new Person();
        }
    }
}

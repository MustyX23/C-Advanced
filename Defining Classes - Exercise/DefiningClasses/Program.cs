using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hasan", 13);

            Console.WriteLine(person.Name +" - " +person.Age);
        }
    }
}

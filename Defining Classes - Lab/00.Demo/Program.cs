using System;

namespace _00.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Name = "Sharo");
            dog.AnimalSound();
            Cat cat = new Cat();
            Console.WriteLine(cat.Name = "Macka");
            cat.AnimalSound();
        }
    }
    public class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("An animal makes this sound:");
        }
    }
    public class Cat : Animal
    {
        public string Name { get; set; }
        public void AnimalSound()
        {

            Console.WriteLine("Meow, Meow, Meeooow");
        }
    }
    public class Dog : Animal
    {
        public string Name { get; set; }
        public void AnimalSound()
        {
            Console.WriteLine("Woof, Wooof, Wooooff");
        }
    }

}

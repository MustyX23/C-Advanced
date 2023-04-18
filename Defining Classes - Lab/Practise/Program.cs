using System;

namespace Practise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model ="X3",
                Year = 2018,
                CurrentSpeed = 120
            };

            car._ToString();
            Console.WriteLine("------------------");

            //Accelerate
            for (int i = 0; i < 3; i++)
            {
                car.Accelerate();
                car.TopSpeed = car.CurrentSpeed;
            }

            Console.WriteLine($"Top speed: {car.TopSpeed} mph.");

            //Brake
            for (int i = 0; i < 2; i++)
            {
                car.Brake();
                Console.WriteLine($"You are going with: {car.CurrentSpeed} mph.");
            }

        }
    }
    public class Car
    {
        //Make(string)
        public string Make { get; set; }
        //Model(string)
        public string Model { get; set; }
        //Year(int)
        public int Year { get; set; }
        //TopSpeed(int)
        public int TopSpeed { get; set; }
        //CurrentSpeed(int)
        public int CurrentSpeed { get; set; }

        public int Accelerate()
        {
            return CurrentSpeed += 10;
        }
        public int Brake()
        {
            return CurrentSpeed -= 10;
        }
        public void _ToString()
        {
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nCurrent Speed: {CurrentSpeed}");
        }
    }
}

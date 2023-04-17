using System;

namespace CarManufacturer

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Mark = "BMW",
                Model = "3",
                Year = 2018
            };

            Console.WriteLine(car.Mark);
        }
    }
}

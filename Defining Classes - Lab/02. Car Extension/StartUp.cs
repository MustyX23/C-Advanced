using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "VW",
                Model = "MK3",
                Year = 1992,
                FuelConsumption = 0.3,
                FuelQuantity = 100,                                
            };

            while (true)
            {
                Console.WriteLine("Where to go?");

                car.Drive(int.Parse(Console.ReadLine()));

                Console.WriteLine($"Fuel left: {car.FuelQuantity}");
            }
            
        }
    }
}

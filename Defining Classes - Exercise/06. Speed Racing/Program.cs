using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"

                string[]arguments = Console.ReadLine().Split(' ');

                string model = arguments[0];
                double fuelAmount = double.Parse(arguments[1]);
                double fuelConsumptionFor1km = double.Parse(arguments[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km));
            }

            string command;

            while ((command = Console.ReadLine())!= "End")
            {
                //"Drive {carModel} {amountOfKm}"
                string[]carInfo = command.Split(' ');
                string carModel = carInfo[1];
                double amountOfKm = double.Parse(carInfo[2]);

                Car car = cars.Find(c => c.Model == carModel);
                if (car.CanMove(amountOfKm) == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

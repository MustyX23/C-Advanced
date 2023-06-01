using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int numberOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length == 3)
                {
                    string displacementString = input[2];
                    if (char.IsLetter(displacementString[0]))
                    {
                        string efficiency = displacementString;
                        Engine newEngine = new Engine(model, power, efficiency);
                        engines.Add(newEngine);
                    }
                    else if (char.IsDigit(displacementString[0]))
                    {
                        int displacement = int.Parse(displacementString);
                        Engine newEngine = new Engine(model, power, displacement);
                        engines.Add(newEngine);
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    Engine newEngine = new Engine(model, power, displacement, efficiency);
                    engines.Add(newEngine);
                }
                else
                {
                    Engine newEngine = new Engine(model, power);
                    engines.Add(newEngine);
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];

                if (input.Length == 3)
                {
                    string weightString = input[2];
                    if (char.IsLetter(weightString[0]))
                    {
                        string colour = weightString;
                        Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);
                        Car newCar = new Car(model, engine, colour);
                        cars.Add(newCar);
                    }
                    else if (char.IsDigit(weightString[0]))
                    {
                        int weight = int.Parse(weightString);
                        Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);
                        Car newCar = new Car(model, engine, weight);
                        cars.Add(newCar);
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string colour = input[3];
                    Engine engine = engines.First(e => e.Model == engineModel);
                    Car newCar = new Car(model, engine, weight, colour);
                    cars.Add(newCar);
                }
                else
                {
                    Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);
                    Car newCar = new Car(model, engine);
                    cars.Add(newCar);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {(car.Engine.Displacement == 0 ? "n/a" : $"{car.Engine.Displacement}")}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {(car.Weight == 0 ? "n/a" : $"{car.Weight}")}");
                Console.WriteLine($"  Color: {car.Colour}");
            }
        }
    }
}

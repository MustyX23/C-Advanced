﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //•	Make: string
        public string Make { get; set; }
        //•	Model: string
        public string Model { get; set; }
        //•	Year: int
        public int Year { get; set; }
        //•	FuelQuantity: double
        public double FuelQuantity { get; set; }
        //•	FuelConsumption: double
        public double FuelConsumption { get; set; }

        //•	Drive(double distance): void

        public void Drive (double distance)
        {
            //Car fuel quantity minus the distance
            //multiplied by the car fuel consumption
            //is bigger than zero.

            double capacity = FuelQuantity - (distance * FuelConsumption);
            if (capacity > 0)
            {
                //The result of the multiplication between the distance and the fuel consumption.
                FuelQuantity = capacity;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
        }

        public string WhoAmI()
        { 
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }
    }
}

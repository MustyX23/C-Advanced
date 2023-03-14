using System;
using System.Linq;

namespace _07_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            int startIndex = 0;
            int truckFuel = 0;

            for (int i = 0; i < pumpsCount; i++)
            {
                var pumpData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = pumpData[0];
                int distance = pumpData[1];

                truckFuel += fuel - distance;

                if (truckFuel < 0)
                {
                    truckFuel = 0;
                    startIndex = i + 1;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
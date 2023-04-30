using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            Func<double, double> vat = x => x * 0.2 + x;

            foreach (var number in numbers)
            {
                Console.WriteLine($"{vat(number):f2}");
            }
        }
    }
}

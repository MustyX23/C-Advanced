using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hey = "Hello";
            Console.WriteLine(hey.Reverse().ToArray());

            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SumAndGo(integers);
            //int a = 10;
            //int b = 20;

            //Func<int, int, int> sum = (a, b) => a + b;
            //Func<int, int, int> multiply = (a, b) => a * b;
            //Func<int, int, int> divide = (a, b) => a / b;
            //Func<int, int, int> subtract = (a, b) => a - b;

            //Console.WriteLine(sum(a, b));
            //Console.WriteLine(multiply (a, b));
            //Console.WriteLine(divide(a, b));
            //Console.WriteLine(subtract(a, b));

            Predicate<int> isBiggerThan10 = x => x > 10;
            Predicate<int> isNegative = x => x < 0;

            List<int> nums = new List<int>{ 1, 2, -3, 11, 12, 31 };
            var big = nums.FindAll(isBiggerThan10);

            Console.WriteLine(String.Join(" ", big));
        }

        static int MakeCalculations(int x, int y, Func<int, int, int> operators)
        {
            return operators(x, y);
        }
        
        static void ReverseString(string input)
        {
            Array.Reverse(input.ToCharArray());            
        }

        static void SumAndGo(List<int> integers)
        {
            Console.WriteLine(integers.Sum());
            Console.WriteLine(integers.Average());
        }
    }
}

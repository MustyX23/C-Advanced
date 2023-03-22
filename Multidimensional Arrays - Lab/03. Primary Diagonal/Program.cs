using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int square = int.Parse(Console.ReadLine());
            int[,] matrix = new int[square, square];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = elements[column];
                }
            }

            for (int i = 0; i < square; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}

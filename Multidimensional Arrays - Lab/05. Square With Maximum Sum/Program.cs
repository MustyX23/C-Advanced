using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[array[0], array[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = elements[column];
                }
            }

            //Submatrix...
            int biggestSum = int.MinValue;
            int subRow = 0;
            int subCol = 0;
            
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] +
                        matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        subRow = row;
                        subCol = col;
                    }

                }
            }
            Console.WriteLine($"{matrix[subRow, subCol]} {matrix[subRow, subCol + 1]}");
            Console.WriteLine($"{matrix[subRow + 1, subCol]} {matrix[subRow + 1, subCol + 1]}");
            Console.WriteLine(biggestSum);
        }
    }
}

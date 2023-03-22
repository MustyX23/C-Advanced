using System;
using System.Linq;

namespace _._01_Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[array[0], array[1]];
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[]elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}

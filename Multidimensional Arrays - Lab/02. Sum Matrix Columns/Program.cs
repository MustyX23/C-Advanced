using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int [array[0], array[1]];
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = elements[column];
                }
            }

            for (int column = 0; column < array[1]; column++)
            {
                int sum = 0;

                for (int row = 0; row < array[0]; row++)
                {
                    sum += matrix[row, column];                    
                }

                Console.WriteLine(sum);
            }
        }
    }
}

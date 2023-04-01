using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[,] matrix = new char [sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int counter = 0;

            //if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
            //{
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        if (matrix[row, col] == matrix[row + 1, col]
                            && matrix[row, col] == matrix[row, col + 1]
                            && matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            counter++;
                        }
                    }
                }
                Console.WriteLine(counter);
            //}
            
        }
    }
}

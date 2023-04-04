using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                string[]commandArgs = input.Split(' ');

                string action = commandArgs[0];
               
                if (action == "swap" && commandArgs.Length == 5)
                {
                    int row1 = int.Parse(commandArgs[1]);
                    int col1 = int.Parse(commandArgs[2]);
                    int row2 = int.Parse(commandArgs[3]);
                    int col2 = int.Parse(commandArgs[4]);

                    if (row1 >= 0 && row1 <= matrix.GetLength(0) && col1 >= 0 && col1 <= matrix.GetLength(1)
                        && row2 >= 0 && row2 <= matrix.GetLength(0) && col2 >= 0 && col2 <= matrix.GetLength(1))
                    {
                        string firstValue = matrix[row1, col1];
                        string secondValue = matrix[row2, col2];

                        matrix[row1, col1] = secondValue;
                        matrix[row2, col2] = firstValue;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}

using System;
using System.Linq;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[,] matrix = new char [size[0], size[1]];

            string snake = Console.ReadLine();
            int currentSnakeIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentSnakeIndex == snake.Length)
                        {
                            currentSnakeIndex = 0;
                        }
                        matrix[row, col] = snake[currentSnakeIndex];
                        currentSnakeIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currentSnakeIndex == snake.Length)
                        {
                            currentSnakeIndex = 0;
                        }

                        matrix[row, col] = snake[currentSnakeIndex];
                        currentSnakeIndex++;
                    }
                }              
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

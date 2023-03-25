using System;

namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string text = Console.ReadLine();
                char[] elements = text.ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            int row = 0;
            int column = 0;

            bool isFound = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {               
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (matrix[rows, columns] == symbol)
                    {
                        row = rows;
                        column = columns;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"({row}, {column})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}

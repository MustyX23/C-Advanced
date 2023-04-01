using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int [n, n];

            for (int row = 0; row < n; row++)
            {
                int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {                    
                    matrix[row, col] = elements[col];
                }
            }

            int leftSum = 0;
            int rightSum = 0;
            

            for (int i = 0; i < n; i++)
            {
                leftSum += matrix[i, i];
            }

            for (int i = 0; i < n; i++)
            {
                rightSum += matrix[i, n - i - 1];
            }

            int sum = Math.Abs(leftSum - rightSum);
            Console.WriteLine(sum);

        }
    }
}

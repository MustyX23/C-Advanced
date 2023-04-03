using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][]jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] jaggedElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[row] = jaggedElements;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int firstCol = 0; firstCol < jagged[row].Length; firstCol++)
                    {
                        jagged[row][firstCol] /= 2;                       
                    }
                    for (int secondCol = 0; secondCol < jagged[row + 1].Length; secondCol++)
                    {
                        jagged[row + 1][secondCol] /= 2;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[]tokens = input.Split(' ');

                string action = tokens[0];

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (tokens.Length == 4 && ValidCordinates(tokens, jagged) == true)
                {
                    if (action == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }                              
            }
            foreach (var row in jagged)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }

        static bool ValidCordinates(string[]commandArgs, int[][]jagged)
        {
            int row = int.Parse(commandArgs[1]);
            int col = int.Parse(commandArgs[2]);

            if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][]jagged = new int[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string commands;

            while ((commands = Console.ReadLine())!= "END")
            {
                string[] tokens = commands.Split(' ');

                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && col >= 0 && row < jagged.Length && col < jagged[row].Length)
                {
                    if (action == "Add")
                    {
                        jagged[row][col]+=value;
                    }
                    else if (action == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(String.Join(" ",row));
            }

        }
    }
}

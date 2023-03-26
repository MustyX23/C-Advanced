using System;

namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jagged = new long[n][];
            jagged[0] = new long[1];
            jagged[0][0] = 1; 

            for (int i = 1; i < jagged.Length; i++)
            {
                jagged[i] = new long [i + 1];
                jagged [i][0] = 1;
                jagged [i][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
                }
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}

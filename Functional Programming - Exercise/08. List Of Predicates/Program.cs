using System;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] dividers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> divisibleNumbers = FindDivisibleNumbers(N, dividers);
            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }

        static List<int> FindDivisibleNumbers(int N, int[] dividers)
        {
            List<int> divisibleNumbers = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                if (IsDivisibleByAll(i, dividers))
                {
                    divisibleNumbers.Add(i);
                }
            }

            return divisibleNumbers;
        }

        static bool IsDivisibleByAll(int number, int[] dividers)
        {
            foreach (int divider in dividers)
            {
                if (number % divider != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

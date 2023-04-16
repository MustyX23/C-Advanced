using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        // Reverse the collection
        numbers.Reverse();

        // Remove elements that are divisible by n
        int n = 2;
        numbers = RemoveDivisibleByN(numbers, n);

        // Print the resulting collection
        Console.WriteLine(string.Join(" ", numbers));
    }

    static List<int> RemoveDivisibleByN(List<int> numbers, int n)
    {
        return numbers.Where(x => x % n != 0).ToList();
    }
}

using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = x => char.IsUpper(x[0]);
            var words = Console.ReadLine().Split(" ").Where(checker);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

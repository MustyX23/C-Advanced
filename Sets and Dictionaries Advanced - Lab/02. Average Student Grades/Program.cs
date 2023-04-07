using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentRecord = new Dictionary<string, List<decimal>>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[]input = Console.ReadLine().Split(' ');

                string name = input[0];
                decimal score = decimal.Parse(input[1]);

                if (!studentRecord.ContainsKey(name))
                {
                    studentRecord[name] = new List<decimal>();
                }

                studentRecord[name].Add(score);
            }

            foreach (var (student, grades) in studentRecord)
            {
                decimal average = grades.Average();
                Console.Write($"{student} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }

        }
    }
}

using System;
using System.IO;

namespace StreamBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using StreamReader
            StreamReader reader = new StreamReader("../../../input.txt");

            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();

                while (line != null)
                {                   
                    Console.WriteLine($"{counter++}. {line}");
                    line = reader.ReadLine();
                }
            }

            //Using StreamWriter
            StreamWriter writer = new StreamWriter("../../../input.txt");
            using (writer)
            {
                //It is re-writing the old input.txt
                writer.WriteLine("I am writing in the StreamWriter");
            }
        }
    }
}

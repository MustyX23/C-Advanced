using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int counter = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

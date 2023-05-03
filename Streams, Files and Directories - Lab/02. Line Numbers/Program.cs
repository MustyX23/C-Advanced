namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"../../../input.txt";
            string outputPath = @"../../../output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);

            using (reader)
            {
                string line = reader.ReadLine();
                int counter = 1;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter++}. {line}");
                        line = reader.ReadLine();
                    }
                }
                
            }
        }
    }
}

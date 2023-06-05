namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder result = new StringBuilder();
            int lineCounter = 1;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        int letterCount = CountLetters(line);
                        int punctuationCount = CountPunctuation(line);
                        writer.WriteLine($"Line {lineCounter}: {line} ({letterCount})({punctuationCount})");
                        lineCounter++;
                    }
                }
            }
            
        }
        private static int CountLetters(string line)
        {
            int count = 0;
            foreach (var c in line)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
        private static int CountPunctuation(string line)
        {
            int count = 0;
            foreach (var c in line)
            {
                if (char.IsPunctuation(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

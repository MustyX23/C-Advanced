namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            StreamReader streamReader = new StreamReader(inputFilePath);
            Console.WriteLine(ProcessLines(inputFilePath));

        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder result = new StringBuilder();
            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                int countOfLines = 0;

                while (!streamReader.EndOfStream)
                {
                    
                    string line = streamReader.ReadLine();
                    if (countOfLines % 2 == 0)
                    {
                        line = line.Replace("-", "@")
                            .Replace(",", "@")
                            .Replace(".", "@")
                            .Replace("!", "@")
                            .Replace("?", "@");
                        string[]words = line.Split(' ');
                        Array.Reverse(words);
                        line = string.Join(' ',words);
                        result.AppendLine(line);
                    }
                    countOfLines++;
                }
            }
            return result.ToString();
        }
    }
}

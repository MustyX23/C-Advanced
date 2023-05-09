namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"../../../words.txt";
            string textPath = @"../../../text.txt";
            string outputPath = @"../../../output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            // Read the list of words to find frequency for
            string[] wordsToFind = File.ReadAllLines("../../../words.txt");

            // Read the text file to search for those words
            string text = File.ReadAllText(".../../../text.txt");

            // Split the text into words
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Find the frequency of each word, case-insensitive
            Dictionary<string, int> frequencies = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (string word in words)
            {
                if (wordsToFind.Contains(word, StringComparer.OrdinalIgnoreCase))
                {
                    if (frequencies.ContainsKey(word))
                    {
                        frequencies[word]++;
                    }
                    else
                    {
                        frequencies[word] = 1;
                    }
                }
            }

            // Sort the words by frequency in descending order
            var sortedFrequencies = frequencies.OrderByDescending(x => x.Value);

            // Write the results to the output file
            using (StreamWriter sw = new StreamWriter("../../../output.txt"))
            {
                foreach (var kvp in sortedFrequencies)
                {
                    sw.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}

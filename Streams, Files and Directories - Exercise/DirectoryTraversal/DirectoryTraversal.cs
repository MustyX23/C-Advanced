namespace DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var filesByExtencion = Directory.GetFiles(inputFolderPath)
                .GroupBy(file => Path.GetExtension(file).ToLower())
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key);

            StringBuilder report = new StringBuilder();

            foreach (var extencionGroup in filesByExtencion)
            {
                report.AppendLine(extencionGroup.Key);

                foreach (var file in extencionGroup.OrderBy(file => new FileInfo(file).Length))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    report.AppendLine($"--{fileInfo.Name} - {fileInfo.Length / 1024}kb");
                }
            }

            return report.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportFilePath = desktopPath + reportFileName;

            using (StreamWriter writer = new StreamWriter(reportFilePath))
            {
                writer.WriteLine(textContent);
            }

            Console.WriteLine($"Report saved to: {reportFilePath}");
        }
    }
}

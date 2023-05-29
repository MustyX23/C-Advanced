namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            const int bufferSize = 4096; // 4KB buffer size

            using (FileStream source = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream destination = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[bufferSize];
                    int bytesRead;

                    while ((bytesRead = source.Read(buffer, 0, bufferSize)) > 0)
                    {
                        destination.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}

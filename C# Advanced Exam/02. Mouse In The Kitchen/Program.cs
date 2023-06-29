using System;
using System.Linq;

namespace _02._Mouse_In_The_Kitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] cupboard = new char[rows][];

            int mouseRow = 0;
            int mouseCol = 0;

            for (int row = 0; row < rows; row++)
            {
                cupboard[row] = Console.ReadLine().ToCharArray();
                if (cupboard[row].Contains('M'))
                {
                    mouseRow = row;
                    mouseCol = Array.IndexOf(cupboard[row], 'M');
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "danger")
            {
                cupboard[mouseRow][mouseCol] = '*';

                switch (command)
                {
                    case "up":
                        mouseRow--;
                        break;
                    case "down":
                        mouseRow++;
                        break;
                    case "left":
                        mouseCol--;
                        break;
                    case "right":
                        mouseCol++;
                        break;
                }

                if (mouseRow < 0 || mouseRow >= rows || mouseCol < 0 || mouseCol >= cols)
                {
                    Console.WriteLine("No more cheese for tonight!");
                    cupboard[mouseRow < 0 ? 0 : mouseRow >= rows ? rows - 1 : mouseRow][mouseCol < 0 ? 0 : mouseCol >= cols ? cols - 1 : mouseCol] = 'M';
                    PrintCupboard(cupboard);
                    return;
                }

                char currentCell = cupboard[mouseRow][mouseCol];
                if (currentCell == '@')
                {
                    switch (command)
                    {
                        case "up":
                            mouseRow++;
                            break;
                        case "down":
                            mouseRow--;
                            break;
                        case "left":
                            mouseCol++;
                            break;
                        case "right":
                            mouseCol--;
                            break;
                    }
                }
                else if (currentCell == 'C')
                {
                    cupboard[mouseRow][mouseCol] = '*';
                    if (!cupboard.Any(row => row.Contains('C')))
                    {
                        cupboard[mouseRow][mouseCol] = 'M';
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        PrintCupboard(cupboard);
                        return;
                    }
                }
                else if (currentCell == 'T')
                {
                    cupboard[mouseRow][mouseCol] = 'M';
                    Console.WriteLine("Mouse is trapped!");
                    PrintCupboard(cupboard);
                    return;
                }

                cupboard[mouseRow][mouseCol] = 'M';
            }

            Console.WriteLine("Mouse will come back later!");
            PrintCupboard(cupboard);
        }

        private static void PrintCupboard(char[][] cupboard)
        {
            foreach (char[] row in cupboard)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}

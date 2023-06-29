using System;
using System.Linq;

namespace ArmyOfficer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] armory = new char[n, n];
            int officerRow = 0;
            int officerCol = 0;
            int mirrorRow1 = -1;
            int mirrorCol1 = -1;
            int mirrorRow2 = -1;
            int mirrorCol2 = -1;
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    armory[row, col] = line[col];
                    if (line[col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                    else if (line[col] == 'M')
                    {
                        if (mirrorRow1 == -1)
                        {
                            mirrorRow1 = row;
                            mirrorCol1 = col;
                        }
                        else
                        {
                            mirrorRow2 = row;
                            mirrorCol2 = col;
                        }
                    }
                }
            }

            int profit = 0;
            bool leftArmory = false;

            while (profit < 65)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        officerRow--;
                        break;
                    case "down":
                        officerRow++;
                        break;
                    case "left":
                        officerCol--;
                        break;
                    case "right":
                        officerCol++;
                        break;
                }

                if (officerRow < 0 || officerRow >= n || officerCol < 0 || officerCol >= n)
                {
                    leftArmory = true;
                    break;
                }

                char currentCell = armory[officerRow, officerCol];
                if (char.IsDigit(currentCell))
                {
                    profit += currentCell - '0';
                    armory[officerRow, officerCol] = '-';
                }
                else if (currentCell == 'M')
                {
                    armory[officerRow, officerCol] = '-';
                    if (officerRow == mirrorRow1 && officerCol == mirrorCol1)
                    {
                        officerRow = mirrorRow2;
                        officerCol = mirrorCol2;
                    }
                    else
                    {
                        officerRow = mirrorRow1;
                        officerCol = mirrorCol1;
                    }
                    armory[officerRow, officerCol] = '-';
                }
            }

            Console.WriteLine(leftArmory ? "I do not need more swords!" : "Very nice swords, I will come back for more!");
            Console.WriteLine($"The king paid {profit} gold coins.");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(armory[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
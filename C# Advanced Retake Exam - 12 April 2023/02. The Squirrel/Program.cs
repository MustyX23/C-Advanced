using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Squirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            Queue<string> commands = new Queue<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            string[,] field = new string[fieldSize, fieldSize];

            bool isTrappedOrLeft = false;

            int squirrelRow = -1;
            int squirrelCol = -1;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = row[j].ToString();
                    if (field[i, j] == "s")
                    {
                        squirrelRow = i;
                        squirrelCol = j;
                        field[i, j] = "*";
                    }
                }
            }

            int hazelnutsCollected = 0;

            while (hazelnutsCollected < 3 && commands.Any())
            {
                string direction = commands.Dequeue();

                if (OutOfBounds(direction, squirrelCol, squirrelRow, field) ||
                    PositionIsATrap(direction, squirrelCol, squirrelRow, field))
                {
                    break;
                }

                switch (direction)
                {
                    case "left":
                        squirrelCol--;
                        break;
                    case "right":
                        squirrelCol++;
                        break;
                    case "up":
                        squirrelRow--;
                        break;
                    case "down":
                        squirrelRow++;
                        break;
                }

                if (field[squirrelRow, squirrelCol] == "h")
                {
                    hazelnutsCollected++;
                    field[squirrelRow, squirrelCol] = "*";
                }
            }

            if (!isTrappedOrLeft)
            {
                if (hazelnutsCollected == 3)
                {
                    Console.WriteLine($"Good job! You have collected all hazelnuts!");
                }
                else
                {
                    Console.WriteLine($"There are more hazelnuts to collect.");
                }
            }

            Console.WriteLine($"Hazelnuts collected: {hazelnutsCollected}");

            bool PositionIsATrap(string direction, int squirrelCol, int squirrelRow, string[,] field)
            {
                if (direction == "left")
                {
                    squirrelCol--;
                }
                else if (direction == "right")
                {
                    squirrelCol++;
                }
                else if (direction == "up")
                {
                    squirrelRow--;
                }
                else if (direction == "down")
                {
                    squirrelRow++;
                }               
                if (field[squirrelRow, squirrelCol] == "t")
                {
                    Console.WriteLine($"Unfortunately, the squirrel stepped on a trap...");
                    isTrappedOrLeft = true;
                    return true;
                }
                return false;
            }

            bool OutOfBounds(string direction, int squirrelCol, int squirrelRow, string[,] field)
            {
                if ((direction == "left" && squirrelCol == 0) ||
                    (direction == "right" && squirrelCol == field.GetLength(1) - 1) ||
                    (direction == "up" && squirrelRow == 0) ||
                    (direction == "down" && squirrelRow == field.GetLength(0) - 1))
                {
                    Console.WriteLine($"The squirrel is out of the field.");
                    isTrappedOrLeft = true;
                    return true;
                }

                return false;
            }
        }
    }         
}

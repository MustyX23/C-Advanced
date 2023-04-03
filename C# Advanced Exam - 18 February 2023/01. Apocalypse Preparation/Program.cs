using System;
using System.Collections.Generic;
using System.Linq;

namespace ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> textiles = new Queue<int>(firstArray);

            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> medicaments = new Stack<int>(secondArray);

            int patch = 30;
            int bandage = 40;
            int medkit = 100;

            Dictionary<string, int> createdItems = new Dictionary<string, int>();

            while (textiles.Count != 0 && medicaments.Count != 0)
            {
                int firstTextile = textiles.Dequeue();
                int lastMed = medicaments.Pop();

                int resource = firstTextile + lastMed;

                if (resource == patch || resource == bandage || resource == medkit)
                {
                    if (!createdItems.ContainsKey(GetItemName(resource)))
                    {
                        createdItems[GetItemName(resource)] = 0;
                    }
                    createdItems[GetItemName(resource)]++;
                }
                else if (resource > medkit)
                {
                    if (!createdItems.ContainsKey("MedKit"))
                    {
                        createdItems["MedKit"] = 0;
                    }
                    createdItems["MedKit"]++;

                    resource -= 100;
                    int nextValue = medicaments.Pop();
                    medicaments.Push(resource + nextValue);
                }
                else
                {
                    lastMed += 10;
                    medicaments.Push(lastMed);
                }

            }

            PrintOutput(textiles, medicaments, createdItems);
        }

        private static string GetItemName(int resource)
        {
            if (resource == 30)
            {
                return "Patch";
            }
            else if (resource == 40)
            {
                return "Bandage";
            }
            else if (resource == 100)
            {
                return "MedKit";
            }
            else
            {
                return "";
            }
        }

        private static void PrintOutput(Queue<int> textiles, Stack<int> medicaments, Dictionary<string, int> createdItems)
        {
            if (textiles.Count == 0 && medicaments.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if (textiles.Count == 0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if (medicaments.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }

            var sortedItems = createdItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in sortedItems)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            if (textiles.Count > 0)
            {
                Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
            }

            if (medicaments.Count > 0)
            {
                Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
            }

        }
    }
}

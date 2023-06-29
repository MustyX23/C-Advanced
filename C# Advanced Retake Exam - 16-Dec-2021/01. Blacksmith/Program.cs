using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] steel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] carbon = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int swordCount = 0;

        Queue<int> steelQueue = new Queue<int>(steel);
        Stack<int> carbonStack = new Stack<int>(carbon);

        SortedDictionary<string, int> swords = new SortedDictionary<string, int>()
        {
            { "Gladius", 70 },
            { "Shamshir", 80 },
            { "Katana", 90 },
            { "Sabre", 110 },
            { "Broadsword", 150 }
        };

        Dictionary<string, int> forgedSwords = new Dictionary<string, int>();

        while (steelQueue.Count > 0 && carbonStack.Count > 0)
        {
            int currentSteel = steelQueue.Dequeue();
            int currentCarbon = carbonStack.Pop();
            int sum = currentSteel + currentCarbon;

            if (swords.ContainsValue(sum))
            {
                string swordName = GetKeyByValue(swords, sum);
                if (forgedSwords.ContainsKey(swordName))
                {
                    forgedSwords[swordName]++;
                    swordCount++;
                }
                else
                {
                    forgedSwords[swordName] = 1;
                    swordCount++;
                }

            }
            else
            {
                carbonStack.Push(currentCarbon + 5);
            }
        }

        if (forgedSwords.Count == 0)
        {
            Console.WriteLine("You did not have enough resources to forge a sword.");
        }
        else
        {
            Console.WriteLine("You have forged {0} swords.", swordCount);
        }

        Console.WriteLine("Steel left: {0}", steelQueue.Count == 0 ? "none" : string.Join(", ", steelQueue));
        Console.WriteLine("Carbon left: {0}", carbonStack.Count == 0 ? "none" : string.Join(", ", carbonStack));

        foreach (var sword in swords)
        {
            if (forgedSwords.ContainsKey(sword.Key))
            {
                Console.WriteLine("{0}: {1}", sword.Key, forgedSwords[sword.Key]);
            }
        }
    }

    static string GetKeyByValue<TKey, TValue>(SortedDictionary<TKey, TValue> dictionary, TValue value)
    {
        foreach (var pair in dictionary)
        {
            if (EqualityComparer<TValue>.Default.Equals(pair.Value, value))
            {
                return pair.Key.ToString();
            }
        }
        throw new Exception("Key not found for value: " + value);
    }
}

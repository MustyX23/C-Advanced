using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> chemicalCompounds = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompound = Console.ReadLine().Split(' ');
                for (int j = 0; j < chemicalCompound.Length; j++)
                {
                    chemicalCompounds.Add(chemicalCompound[j]);
                }
                
            }

            foreach (var chemicalCompound in chemicalCompounds.OrderBy(x => x))
            {
                Console.Write($"{chemicalCompound} ");
            }
        }
    }
}

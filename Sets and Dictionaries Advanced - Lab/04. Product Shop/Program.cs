using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string line;

            while ((line = Console.ReadLine()) != "Revision")
            {
                string[] productsInfo = line.Split(", ");

                string shop = productsInfo[0];
                string product = productsInfo[1];
                double price = double.Parse(productsInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
            }

            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var shopAndProducts in orderedShops)
            {
                string shopName = shopAndProducts.Key;
                Console.WriteLine(shopName + "->");
                var products = shopAndProducts.Value;

                foreach (var productAndPrice in products)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value} ");
                }
            }
        }
    }
}

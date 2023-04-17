using System;
using System.Collections.Generic;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dice> dices = new List<Dice>();
           
            for (int i = 0; i < 5; i++)
            {
                Dice dice = ThrowDice();
                dices.Add(dice);
                Console.WriteLine($"{dice.Side}");
            }
        }

        static Dice ThrowDice()
        {
            Random random = new Random();

            int side = random.Next(1, 7);
            string color = "Green";

            Dice dice = new Dice() 
            {
                Side = side,
                Color = color
            };

            return dice;
        }
    }
}

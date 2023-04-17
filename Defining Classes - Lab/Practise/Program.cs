using System;

namespace Practise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle square = new Rectangle(5, 5);

            Console.WriteLine($"The area of the reactangle is: {square.Area()}");
            Console.WriteLine($"The parameter of the reactangle is: {square.Parameter()}");
            Console.WriteLine($"Is the reactangle a square: {square.IsSquare()}");
        }
    }
    public class Rectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public double Parameter()
        {
            return (2 * Width) + (2 * Height);
        }

        public bool IsSquare()
        {
            if (Width == Height)
            {
                return true;
            }
            return false;
        }
    }
}

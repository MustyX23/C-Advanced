namespace ClothesMagazine
{
    public class Cloth
    {
        public Cloth(string color, int size, string type)
        {
            Color = color;
            Size = size;
            Type = type;
        }

        //•	Color - string
        public string Color { get; set; }
        //•	Size - int
        public int Size { get; set; }
        //•	Type - string
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Product: {Type} with size {Size}, color {Color}";
        }
    }
}

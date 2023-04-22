using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        
        //•	Type - string
        public string Type { get; }
        //•	Capacity – int
        public int Capacity { get; }
        //•	Clothes – List<Cloth>
        public List<Cloth> Clothes { get; }

        //•	Method AddCloth(Cloth cloth) – adds an entity to the collection if there is room for it
        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        //•	Method RemoveCloth(string color) – removes a cloth by given color, if such exists,
        //and returns boolean (true if it is removed, otherwise – false)
        public bool RemoveCloth(string color)
        {
            var clothToRemove = Clothes.FirstOrDefault(c => c.Color == color);
            if (clothToRemove != null)
            {
                Clothes.Remove(clothToRemove);
                return true;
            }
            else return false;

        }
        //•	Method GetSmallestCloth() – returns the Cloth with the smallest Size
        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(x => x.Size).FirstOrDefault();
        }
        //•	Method GetCloth(string color) – returns the Cloth with the given color
        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }
        //•	Method GetClothCount() – returns the number of clothes
        public int GetClothCount()
        {
            return Clothes.Count();
        }
        //•	Method Report() – returns a string
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");

            foreach (var cloth in Clothes.OrderBy(x => x.Size))
            {
                sb.AppendLine(cloth.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}

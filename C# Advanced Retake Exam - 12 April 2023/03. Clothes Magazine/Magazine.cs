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

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public bool AddCloth(Cloth cloth)
        {
            if (this.Clothes.Count < this.Capacity)
            {
                Clothes.Add(cloth);
                return true;
            }
            return false;            
        }
        public bool RemoveCloth(string color)
        {
            Cloth cloth = Clothes.FirstOrDefault(c => c.Color == color);
            if (cloth != null)
            {
                Clothes.Remove(cloth);
                return true;
            }
            return false;
        }
        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(c => c.Size).FirstOrDefault();
        }
        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }
        public int GetClothCount()
        {
            return Clothes.Count;
        }
        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Type} magazine contains:");

            foreach (var cloth in Clothes.OrderBy(c => c.Size))
            {
                result.AppendLine(cloth.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}

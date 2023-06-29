using System;
using System.Collections.Generic;
using System.Text;

namespace Drones
{
    public class Drone
    {
        private string name;
        private string brand;
        private int range;

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available  {get; set;}

        public Drone(string name, string brand, int range)
        {
            Name = name;
            Brand = brand;
            Range = range;
            Available = true;
        }

        public override string ToString()
        {
            return $"Drone: {Name}\nManufactured by: {Brand}\nRange: {Range}kilometers";
        }
    }
}

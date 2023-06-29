using System;
using System.Collections.Generic;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private List<Drone> drones;

        public string Name { get; }
        public int Capacity { get; }
        public double LandingStrip { get; }

        public int Count => drones.Count;

        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            drones = new List<Drone>();
        }

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (drones.Count >= Capacity)
            {
                return "Airfield is full.";
            }

            drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            Drone drone = drones.Find(d => d.Name == name);
            if (drone != null)
            {
                drones.Remove(drone);
                return true;
            }
            return false;
        }

        public int RemoveDroneByBrand(string brand)
        {
            int count = drones.RemoveAll(d => d.Brand == brand);
            return count;
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = drones.Find(d => d.Name == name);
            if (drone != null)
            {
                drone.Available = false;
                return drone;
            }
            return null;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> flownDrones = drones.FindAll(d => d.Range >= range);
            foreach (Drone drone in flownDrones)
            {
                drone.Available = false;
            }
            return flownDrones;
        }

        public string Report()
        {
            List<Drone> availableDrones = drones.FindAll(d => d.Available);
            string report = $"Drones available at {Name}:\n";
            foreach (Drone drone in availableDrones)
            {
                report += drone.ToString() + "\n";
            }
            return report;
        }
    }
}

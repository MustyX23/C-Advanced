using System.Collections.Generic;
using System.Linq;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public int ChildrenCount 
        {
            get { return Registry.Count; }
        }

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);                
            }
            return false;
        }
        public bool RemoveChild(string childFullName)
        {
            string[]childsname = childFullName.Split(' ');           
            string firstName = childsname[0];
            string lastName = childsname[1];

            Child childToRemove = Registry.Find(child => child.FirstName == firstName && child.LastName == lastName);

            if (childToRemove != null)
            {
                Registry.Remove(childToRemove);
                return true;
            }

            return false;
        }
        public Child GetChild(string childFullName)
        {
            string[] childsname = childFullName.Split(' ');
            string firstName = childsname[0];
            string lastName = childsname[1];

            Child childToSearch = Registry.Find(child => child.FirstName == firstName && child.LastName == lastName);

            if (childToSearch != null)
            {
                return childToSearch;
            }

            return null;
        }
        public string RegistryReport()
        {
            List<Child> sortedChildren = Registry
            .OrderByDescending(child => child.Age)
            .ThenBy(child => child.LastName)
            .ThenBy(child => child.FirstName)
            .ToList();

            string report = $"Registered children in {Name}:\n";
            report += string.Join("\n", sortedChildren.Select(child => child.ToString()));
            return report;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = familyMembers.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestPerson;
        }

        public List<Person> GetPersonOver30()
        {
            List<Person> peopleOver30 = familyMembers.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            return peopleOver30;
        }
    }
}
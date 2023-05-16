using System;
using System.Collections.Generic;

namespace Non_Generic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementing Non Generic Classes
            object[] array = new object[] {1, 2 ,3 ,4};
            ObjectList nonGenericList = new ObjectList(array);
        }
    }
    public class ObjectList 
    {
        private object[] elements;

        public ObjectList(object[] elements)
        {
            this.elements = new object[4];
        }

        public void Add(object element)
        {
            //...
        }
        public object GetIndex(int index)
        {
            return this.elements[index];
        }
    }
}

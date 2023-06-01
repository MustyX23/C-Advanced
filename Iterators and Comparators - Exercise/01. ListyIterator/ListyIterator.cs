using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
            currentIndex = 0;
        }

        public bool Move()
        {
            if (currentIndex + 1 == elements.Count)
            {
                currentIndex++;
                return true;
            }

            return false;           
        }
        public bool HasNext()
        {
            return currentIndex + 1 < elements.Count;
        }
        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(elements[currentIndex]);
        }
    }
}

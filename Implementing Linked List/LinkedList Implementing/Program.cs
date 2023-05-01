using System;
using System.Collections.Generic;

namespace LinkedList_Implementing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a LinkedList 
            LinkedList<string> linkedList = new LinkedList<string>();

            //Add elements to the LinkedList
            //We use AddLast method
            linkedList.AddLast("Ivan");
            linkedList.AddLast("Dragan");
            linkedList.AddLast("Dimitri4ko");

            Console.WriteLine("The best students of the whole school are:");

            //Accessing elements from the LinkedList using foreach loop

            foreach (string students in linkedList)
            {
                Console.WriteLine(students);
            }

            //Clear(): This method is used to remove all nodes from the LinkedList.
            //Remove(LinkedListNode): This method is used to remove the specified node from the LinkedList.
            //Remove(T): This method is used to remove the first occurrence of the specified value from the LinkedList.
            //RemoveFirst(): This method is used to remove the node at the start of the LinkedList.
            //RemoveLast(): This method is used to remove the node at the end of the LinkedList.
        }
    }
}

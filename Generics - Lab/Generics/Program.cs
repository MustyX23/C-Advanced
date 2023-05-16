using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics introduce the concept of Type Parameters

            //Allow designing classes and methods without parameter type specification

            //Powerful to Reuse Code
            CustomStack<int> customStack = new CustomStack<int>();
        }
    }

    //Initializing the Generic class
    public class CustomStack<T>
    {

    }
    //Blueprint for a type - T (Type Parameter)
    public class List<T>
    {
        //public T Add (T element) {...}
        //public T Remove(T element) {...};
        //public T Peek(T element){...};
    }
}

using System;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            ListyIterator<string> iterator = new ListyIterator<string>();

            string command;

            while ((command = Console.ReadLine())!= "END")
            {
                try
                {
                    if (command == "Move")
                    {
                        iterator.Move();
                    }
                    else if (command == "HasNext")
                    {
                        iterator.HasNext();
                    }
                    else if (command == "Print")
                    {
                        iterator.Print();
                    }
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

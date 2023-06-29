using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> tools = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        Queue<int> substances = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        Queue<int> challenges = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));

        while (challenges.Count > 0 && tools.Count > 0 && substances.Count > 0)
        {
            int tool = tools.Peek();
            int substance = substances.Peek();
            int result = tool * substance;

            if (challenges.Contains(result))
            {
                challenges = new Queue<int>(challenges.Where(c => c != result));
                tools.Pop();
                substances.Dequeue();
            }
            else
            {
                tools.Pop();
                tools.Push(tool + 1);

                substance--;
                if (substance == 0)
                    substances.Dequeue();
                else
                {
                    substances.Dequeue();
                    substances.Enqueue(substance);
                }
            }
        }

        if (tools.Count == 0 || substances.Count == 0)
        {
            Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        }
        else
        {
            Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        }

        Console.WriteLine("Tools: " + string.Join(", ", tools.Reverse()));
        Console.WriteLine("Substances: " + string.Join(", ", substances));
        Console.WriteLine("Challenges: " + string.Join(", ", challenges));
    }
}

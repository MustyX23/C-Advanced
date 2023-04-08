using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input;

            while ((input = Console.ReadLine())!= "Statistics")
            {
                string[]commandPropmts = input.Split(' ');

                string command = commandPropmts[1];
                string vloggerName = commandPropmts[0];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers[vloggerName] = new Dictionary<string, HashSet<string>>();
                        vloggers[vloggerName].Add("followers", new HashSet<string>());
                        vloggers[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string member = commandPropmts[2];

                    if (vloggerName != member && vloggers.ContainsKey(member) && vloggers.ContainsKey(vloggerName))
                    {
                        vloggers[vloggerName]["following"].Add(member);
                        vloggers[vloggerName]["followed"].Add(member);
                    }
                }
             
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            
        }
    }
}

using System;

namespace UndeadorAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            if (input.Contains(":)") && !input.Contains(":("))
            {
                output = "alive";
            }
            else if (input.Contains(":(") && !input.Contains(":)"))
            {
                output = "undead";
            }
            else if(input.Contains(":)") && input.Contains(":("))
            {
                output = "double agent";
            }
            else
            {
                output = "machine";
            }
            Console.WriteLine(output);
        }
    }
}

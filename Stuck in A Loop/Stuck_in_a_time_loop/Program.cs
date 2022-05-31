using System;

namespace Stuck_in_a_time_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Eingabe = Int32.Parse(Console.ReadLine());

           for(int i = 0; i < Eingabe; i++)
            {
                Console.WriteLine(i + 1 + " " + "Abracadabra");
            }
        }
    }
}

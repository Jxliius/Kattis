using System;

namespace Kattis_Take_two_Stones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe = Int32.Parse(Console.ReadLine());

            if(eingabe % 2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}

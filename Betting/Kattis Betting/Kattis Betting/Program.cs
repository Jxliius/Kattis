using System;

namespace Kattis_Betting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Einlesen = Convert.ToInt32(Console.ReadLine());

            double Erg = 100 - Einlesen;

            Console.WriteLine(100/Einlesen);
            Console.WriteLine(100/Erg);
        }
    }
}

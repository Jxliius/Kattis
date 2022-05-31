using System;

namespace Kattis_Faktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string Eingabe = Convert.ToString(Console.ReadLine());

            string[] Array = Eingabe.Split(' ');
            double Erg = 0;

            Erg = Int32.Parse(Array[0]) * Int32.Parse(Array[1]);

            Erg -= Int32.Parse(Array[0]) - 1;

            Console.WriteLine(Erg);
        }
    }
}

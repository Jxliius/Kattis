using System;

namespace Planina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Zahl = Convert.ToDouble(Console.ReadLine());

            double Erg = Math.Pow(2, Zahl) + 1;

            Console.WriteLine(Erg * Erg);
        }
    }
}

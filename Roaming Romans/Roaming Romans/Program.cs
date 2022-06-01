using System;

namespace Roaming_Romans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Mult = Convert.ToDouble(Console.ReadLine());

            double Erg = 1000.0 * (5280.0 / 4854.0);
            Erg *= Mult;
            Console.WriteLine(Math.Round(Erg));   
        }
    }
}

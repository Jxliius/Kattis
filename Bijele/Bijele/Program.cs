using System;
namespace Bijele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());
            string[]Split = Einlesen.Split(' ');
            string sol = string.Empty;
            int Erg = 0;

            Erg =  1 - Convert.ToInt32(Split[0]);
            sol += Erg + " ";
            Erg = 1 - Convert.ToInt32(Split[1]);
            sol += Erg + " ";
            Erg = 2 - Convert.ToInt32(Split[2]);
            sol += Erg + " ";
            Erg = 2 - Convert.ToInt32(Split[3]);
            sol += Erg + " ";
            Erg = 2 - Convert.ToInt32(Split[4]);
            sol += Erg + " ";
            Erg = 8 - Convert.ToInt32(Split[5]);
            sol += Erg;

            Console.WriteLine(sol);
        }
    }
}

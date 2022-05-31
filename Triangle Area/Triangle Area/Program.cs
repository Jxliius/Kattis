using System;

namespace Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            string[] array = Eingabe.Split(' ');

            double h = Double.Parse(array[0]);
            double b = Double.Parse(array[1]);

            double Erg = 1 / 2.0 * b * h;

            Console.WriteLine(Erg);
        }
    }
}

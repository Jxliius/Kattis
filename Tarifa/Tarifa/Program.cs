using System;

namespace Tarifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Startwert = Convert.ToInt32(Console.ReadLine());
            int Anz = Convert.ToInt32(Console.ReadLine());

            int erga = Startwert * (Anz + 1);
            int ergb = 0;

            for (int i = 0; i < Anz; i++)
            {
                int Werte = Convert.ToInt32(Console.ReadLine());
                ergb += Werte;

            }
            int Erg = erga - ergb;
            Console.WriteLine(Erg);
        }
    }
}

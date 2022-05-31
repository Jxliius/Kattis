using System;

namespace Grass_Seed_Inc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Kosten = Convert.ToDouble(Console.ReadLine());
            int Anz = Convert.ToInt32(Console.ReadLine());
            double Erg = 0;
            

            for(int i = 0; i < Anz; i++)
            {
                string[] A = Console.ReadLine().Split(' ');

                Erg += Convert.ToDouble(A[0]) * Convert.ToDouble(A[1]);
            }
            Erg *= Kosten;
            Console.WriteLine(Math.Round(Erg,6));
        }
    }
}

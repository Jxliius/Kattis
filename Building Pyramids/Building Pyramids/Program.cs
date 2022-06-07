using System;

namespace Building_Pyramids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anz = Convert.ToInt32(Console.ReadLine());
            double Erg = 1;
            double finish = 0;
            int Platzhalter = 1;
            for (int i = 0; i < Anz; i++)
            {
                if(Erg > Anz)
                {
                    break;
                }
                Erg += Math.Pow(Platzhalter + 2, 2);
                Platzhalter += 2;
                finish++;
            }
            Console.WriteLine(finish);
        }
    }
}

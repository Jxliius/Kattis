using System;

namespace Quality_Adjusted_Life_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Eingabe = Convert.ToInt32(Console.ReadLine());
            double Summe = 0.0;
            for(int i = 0; i < Eingabe; i++)
            {
                
                string Platzhalter = Convert.ToString(Console.ReadLine());

                string[]A = Platzhalter.Split(' ');

                Summe += Convert.ToDouble(A[0]) * Convert.ToDouble(A[1]);

            }
            Console.WriteLine(Math.Round(Summe,3));
        }
    }
}

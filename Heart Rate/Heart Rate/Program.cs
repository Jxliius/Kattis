using System;

namespace Heart_Rate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Zeilen = Convert.ToInt32(Console.ReadLine());
            string[]Erg = new string[Zeilen];

            for(int i = 0; i < Zeilen; i++)
            {
                string[]A = Console.ReadLine().Split(' ');

                double b = Convert.ToDouble(A[0]);
                double p = Convert.ToDouble(A[1]);

                double BPM = (60 * b) / p;
                double ABPM = 60 / p;

                Erg[i] = Math.Round(BPM - ABPM,4) + " " + Math.Round(BPM,4) + " " + (Math.Round(BPM + ABPM,4));
            }
            for(int i = 0; i < Erg.Length; i++)
            {
                Console.WriteLine(Erg[i]);
            }
        }
    } 
}

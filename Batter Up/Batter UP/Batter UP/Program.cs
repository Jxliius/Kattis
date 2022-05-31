using System;

namespace Batter_UP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Divisor = Convert.ToDouble(Console.ReadLine());
            string Einlesen = Convert.ToString(Console.ReadLine());
            string[]A = Einlesen.Split(' ');
            double Erg = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if(A[i] == "-1")
                {
                    Divisor--;
                }
                else
                {
                   Erg += Convert.ToDouble(A[i]);
                }
            }
            Erg = Erg / Divisor;
            Console.WriteLine(Erg);
        }
    }
}

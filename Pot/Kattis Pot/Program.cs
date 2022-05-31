using System;

namespace Kattis_Pot
{

    internal class Program
    {
        static string StringFkt(string Wert)
        {
            string Erg = "";
            for(int i = 0; i < Wert.Length - 1; i++)
            {
                Erg += Convert.ToString(Wert[i]);
            }
            return Erg;
        }
        static void Main(string[] args)
        {
            int Einlesen = Convert.ToInt32(Console.ReadLine());
            string[] A = new string[Einlesen];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Console.ReadLine();
            }
            double Erg = 0;
            for(int i = 0; i < A.Length; i++)
            {
                string aufpasser = A[i].Substring(A[i].Length - 1);
                string Wert = StringFkt(A[i]);
                Erg += Math.Pow(Convert.ToDouble(Wert),Convert.ToDouble(aufpasser));
            }
            Console.WriteLine(Erg);
        }
    }
}

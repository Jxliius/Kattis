using System;

namespace N_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Eingabe = Convert.ToInt32(Console.ReadLine());
            string Einlesen = Convert.ToString(Console.ReadLine());
            string[] A = Einlesen.Split(' ');
            int Erg = 0; 
            for(int i = 0; i < Eingabe; i++)
            {
                Erg += Convert.ToInt32(A[i]);
            }
            Console.WriteLine(Erg);
        }
    }
}

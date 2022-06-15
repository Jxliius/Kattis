using System;

namespace Kattis_Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            string[]A = Einlesen.Split(' ');

            int Erg = Convert.ToInt32(A[0]) + Convert.ToInt32(A[1]);
            Console.WriteLine(Erg);
        }
    }
}

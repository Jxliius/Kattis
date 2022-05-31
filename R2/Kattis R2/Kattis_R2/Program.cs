using System;

namespace Kattis_R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            string[] A = Eingabe.Split(' ');
            int R2 = 0;
            R2 = 2 * Convert.ToInt32(A[1]) - Convert.ToInt32(A[0]);
            Console.WriteLine(R2);
        }
    }
}

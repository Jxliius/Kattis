using System;
namespace Chanukah_Challenge
{
    internal class Program
    {
        static string Kalk(string text)
        {
            string[] Split = text.Split(' ');
            int anz = Convert.ToInt32(Split[1]);
            int sol = 0;
            for (int i = 0; i < anz + 1; i++)
            {
                sol += i;
            }
            sol += anz;
            return Split[0] + " " + sol;
        }
        static void Main(string[] args)
        {
            int anz = Convert.ToInt32(Console.ReadLine());
            string[] solA = new string[anz];
            string[] A = new string[anz];
            for (int i = 0; i < anz; i++)
            {
                A[i] = Convert.ToString(Console.ReadLine());
                solA[i] = Kalk(A[i]);
            }
            for (int i = 0; i < solA.Length; i++)
            {
                Console.WriteLine(solA[i]);
            }
        }

    }
}


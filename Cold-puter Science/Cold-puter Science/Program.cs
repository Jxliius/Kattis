using System;

namespace Cold_puter_Science
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anz = Convert.ToInt32(Console.ReadLine());
            string Einlesen = Console.ReadLine();
            string[]A =  Einlesen.Split(' ');
            int count = 0;

            for(int i = 0; i < A.Length; i++)
            {
                if (A[i].Contains("-"))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

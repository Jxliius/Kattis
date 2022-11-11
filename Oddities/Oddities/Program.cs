using System;

namespace Oddities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anz = Convert.ToInt32(Console.ReadLine());
            int[] Zahlen = new int[Anz];
            for (int i = 0; i < Anz; i++)
            {

                Zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int Zahl in Zahlen)
            {
                if (Math.Abs(Zahl) % 2 == 0)
                {
                    Console.WriteLine(Zahl + " is even");
                }
                else
                {
                    Console.WriteLine(Zahl + " is odd");
                }
            }
        }
    }
}

using System;

namespace Nasty_HAcks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EInlesen = Convert.ToInt32(Console.ReadLine());
            double SUm = 0.0;
            string[]Erg = new string[EInlesen];

            for(int i = 0; i < EInlesen; i++)
            {
                string Platzhalter = Convert.ToString(Console.ReadLine());

                string[]A = Platzhalter.Split(' ');

                SUm = Convert.ToDouble(A[0]) + Convert.ToDouble(A[2]);

                if (SUm > Convert.ToDouble(A[1]))
                {
                   Erg[i] = "do not advertise";
                }
                else if (SUm == Convert.ToDouble(A[1]))
                {
                    Erg[i] = "does not matter";
                }
                else if (SUm < Convert.ToDouble(A[1]))
                {
                    Erg[i] = "advertise";
                }

            }
            for(int i = 0;i < Erg.Length; i++)
            {
                Console.WriteLine(Erg[i]);
            }
        }
    }
}

using System;
using System.Linq;

namespace DigitSwap
{
    internal class Program
    {
        /*public static int ZahlInvertieren(int zahl)
        {
            return int.Parse(string.Join(string.Empty,zahl.ToString().Reverse()));
        }*/
        static void Main(string[] args)
        {
            int Zahl = Convert.ToInt32(Console.ReadLine());

            string input = Convert.ToString(Zahl);
            string sol = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                sol += Convert.ToString(input[input.Length - 1 - i]);
            }

            Console.WriteLine(sol);
        }
    }
    
}


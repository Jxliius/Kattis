using System;

namespace Kattis_ElectricalAutlets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Eingabe = Convert.ToInt32(Console.ReadLine());
            string[] Array = new string[Eingabe];
            string Eingabe2 = "";
            for (int i = 0; i < Eingabe; i++)
            {
                Array[i] = Convert.ToString(Console.ReadLine());
            }
        }
    }
}

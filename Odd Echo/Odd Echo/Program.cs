using System;

namespace Odd_Echo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Zahl = Int32.Parse(Console.ReadLine());
            string[] Eingabe = new string [Zahl];

            for(int i = 0; i < Eingabe.Length; i++)
            {
                 Eingabe[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < Eingabe.Length; i = i + 2)
            {
                Console.WriteLine(Eingabe[i]);
            }
            

        }
    }
}

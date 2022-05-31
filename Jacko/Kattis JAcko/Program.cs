using System;

namespace Kattis_JAcko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            string[] f = Eingabe.Split(' ');

            int Erg = 1;
            for (int i = 0; i < f.Length; i++)
            {
                Erg *= Int32.Parse(f[i]);
            }

            Console.WriteLine(Erg);
        }
    }
}

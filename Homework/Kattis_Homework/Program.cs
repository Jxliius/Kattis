using System;

namespace Kattis_Homework
{
    internal class Program
    {

        static int BindesstrichFKt(string test)
        {
            string[] Split = test.Split('-');

            int Erg = Int32.Parse(Split[1]) - Int32.Parse(Split[0]);

            Erg += 1;

            return Erg;
        }

        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            string[] Array = Eingabe.Split(';');
            int Erg = 0;
            for(int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Contains('-'))
                {
                    Erg += BindesstrichFKt(Array[i]);
                }
                else
                {
                    Erg += 1;
                }
            }
            Console.WriteLine(Erg);
        }
    }
}

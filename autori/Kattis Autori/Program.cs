using System;

namespace Kattis_Autori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            string[] Array = Eingabe.Split('-');
            string Antwort = "";
            for(int i = 0; i < Array.Length; i++)
            {
                Antwort += Convert.ToString(Array[i][0]);
            }
            Console.WriteLine(Antwort);
        }
    }
}

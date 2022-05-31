using System;

namespace Kattis_Solving_for_Carrots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eing = Convert.ToString(Console.ReadLine());

            string[]Array = Eing.Split(' ');

            string Lesen = "";

            for(int i = 0; i < Int32.Parse(Array[0]); i++)
            {
                Lesen = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine(Array[1]);
        }
    }
}

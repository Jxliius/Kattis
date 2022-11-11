using System;
namespace Kornislav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            string[] Zahlen = Einlesen.Split(' ');

            Array.Sort(Zahlen);
            Console.WriteLine(Int32.Parse(Zahlen[0]) * Int32.Parse(Zahlen[2]));
        }
    }
}

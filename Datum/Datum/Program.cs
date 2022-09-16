using System;

namespace Datum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            string[] split = Einlesen.Split(' ');
            int Tag = Convert.ToInt32(split[0]);
            int Monat = Convert.ToInt32(split[1]);

            DateTime dateValue = new DateTime(2009, Monat, Tag);
            Console.WriteLine(dateValue.ToString("dddd"));
        }
    }
}

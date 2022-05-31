using System;

namespace Hissing_Microphone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            if (Einlesen.Contains("ss"))
            {
                Console.WriteLine("hiss");
            }
            else
            {
                Console.WriteLine("no hiss");
            }
        }
    }
}

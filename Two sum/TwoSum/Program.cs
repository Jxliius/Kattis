using System;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            string[] Array = Eingabe.Split(' ');

            int Erg = Convert.ToInt32(Array[0]) + Convert.ToInt32(Array[1]);


            Console.WriteLine(Erg);
        }
    }
}

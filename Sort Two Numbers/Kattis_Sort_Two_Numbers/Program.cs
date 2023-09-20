using System;

namespace Kattis_Sort_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            string[] A = Eingabe.Split(' ');

            int a = Int32.Parse(A[0]);
            int b = Int32.Parse(A[1]);

            if(a < b)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.WriteLine(b + " " + a);
            }
        }
    }
}

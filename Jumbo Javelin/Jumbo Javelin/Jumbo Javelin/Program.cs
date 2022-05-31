using System;

namespace Jumbo_Javelin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Zeilen = Convert.ToInt32(Console.ReadLine());

            string[] A = new string[Zeilen];
            int Erg = 0;
            for(int i = 0; i < Zeilen; i++)
            {
                A[i] = Console.ReadLine();
                Erg += Convert.ToInt32(A[i]);
            }
            Erg -= Zeilen - 1;

            Console.WriteLine(Erg);

        }
    }
}

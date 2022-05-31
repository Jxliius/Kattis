using System;

namespace Kattis_Contest2_Fabi_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingbae = Convert.ToString(Console.ReadLine());

            string[] Array = Eingbae.Split('-');
            int[]A = new int[10];
            for(int i = 0; i < 6; i++)
            {
                A[i] = Int32.Parse(Convert.ToString(Array[0][i]));
            }
            for(int i = 6; i < 10; i++)
            {
                A[i] = Int32.Parse(Convert.ToString(Array[1][i - 6]));
            }
            double Erg = 0;
            Erg = A[0] * 4 + A[1] * 3 + A[2] * 2 + A[3] * 7 + A[4] * 6 + A[5] * 5 + A[6] * 4 + A[7] * 3 + A[8] * 2 + A[9] * 1;
            if(Erg % 11 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }   
    }
}
    


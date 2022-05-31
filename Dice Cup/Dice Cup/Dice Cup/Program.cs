using System;

namespace Dice_Cup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            string[] A = Einlesen.Split(' ');
            int z1 = 0, z2 = 0;
            if(Convert.ToInt32(A[0]) < Convert.ToInt32(A[1]))
            {
                z1 = Convert.ToInt32(A[0]);
                z2 = Convert.ToInt32(A[1]);
            }
            else if(Convert.ToInt32(A[0]) > Convert.ToInt32(A[1]))
            {
                z1 = Convert.ToInt32(A[1]);
                z2 = Convert.ToInt32(A[0]);
            }
            else
            {
                z1 = Convert.ToInt32(A[0]);
                z2 = Convert.ToInt32(A[1]);
            }
            for(int i = z1 + 1; i <= z2 + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;

namespace Electrical_Outlets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anz = Convert.ToInt32(Console.ReadLine());
            string[]ErgA = new string[Anz];
                
            for (int i = 0; i < Anz; i++)
            {
                string Eingabe = Convert.ToString(Console.ReadLine());
                string[] A = Eingabe.Split(' ');
                int Erg = 0;
                for (int i2 = 1; i2 < A.Length; i2++)
                {
                    Erg += Convert.ToInt32(A[i2]);
                }
                
                Erg = Erg - Convert.ToInt32(A[0]) + 1;
                ErgA[i] = Convert.ToString(Erg);
            }
            for(int i = 0; i < ErgA.Length; i++)
            {
                Console.WriteLine(ErgA[i]);
            }
        }
    }
}

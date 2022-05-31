using System;

namespace Job_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstInt = Convert.ToInt32(Console.ReadLine());
            string Eingabe = Convert.ToString(Console.ReadLine());
            int Erg = 0;
            string[] A = Eingabe.Split(' ');

            for(int i = 0; i < A.Length; i++)
            {
                if (A[i].Contains("-"))
                {
                    Erg += Convert.ToInt32(A[i]);
                }
            }
            Erg = Erg * -1;
            Console.WriteLine(Erg);
        }
    }
}

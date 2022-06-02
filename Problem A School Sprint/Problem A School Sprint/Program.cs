using System;

namespace Problem_A_School_Sprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anz = Convert.ToInt32(Console.ReadLine());

            double[] A = new double[Anz];
            for(int i = 0; i < Anz; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            double Erg = 0;
            double Zähler = 0;
            double Nenner = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    Erg += A[i] * 1;
                }
                else
                {
                    Zähler = Math.Pow(4, i);
                    Nenner = Math.Pow(5, i);
                    Erg += A[i] * (Zähler / Nenner);
                }
            }
            Erg = (1.0/5.0) * Erg;
            Console.WriteLine(Math.Round(Erg,6));

            double gi = 0;
            int count = 0;
            for (int i = 0; i < Anz; i++)
            {
                double[] A2 = new Double[Anz - 1];
                int count2 = 0;
                for (int i2 = 0; i2 < Anz; i2++)
                {
                    if (i2 != count)
                    {
                        A2[count2] = A[i2];
                        count2++;
                    }
                }
                count++;
                double sol = 0;
                for (int i2 = 0; i2 < A2.Length; i2++)
                {
                    sol += A2[i2] * Math.Pow((4.0 / 5), i2);
                }
                sol *= 1.0 / 5;
                gi += sol;
            }
            gi /= Anz;
            Console.WriteLine(gi);
        }
    }
}

using System;

namespace Detailed_Differences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anz = Convert.ToInt32(Console.ReadLine());
            string[] A = new string[anz * 2];
            string Z1 = string.Empty;
            string[] output = new string[A.Length];

            for (int i = 0; i < anz * 2; i++)
            {
                A[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < A.Length - 1; i = i + 2)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] == A[i + 1][j])
                    {
                        Z1 += ".";
                    }
                    else
                    {
                        Z1 += "*";
                    }
                }
                output[i] = Z1;
                Z1 = "";
            }
            for (int i = 0; i < A.Length - 1; i = i + 2)
            {
                Console.WriteLine(A[i]);
                Console.WriteLine(A[i + 1]);
                Console.WriteLine(output[i]);
                Console.WriteLine(" ");
            }

        }
    }
}

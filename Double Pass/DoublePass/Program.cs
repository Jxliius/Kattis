using System;

namespace DoublePass
{
    internal class Program
    {
        static int GetSol(string P1, string P2)
        {
            int count = 0;
            for(int i = 0; i < P1.Length; i++)
            {
                if(P1[i] != P2[i])
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string Password1 = Convert.ToString(Console.ReadLine());
            string Password2 = Convert.ToString(Console.ReadLine());

            int count = GetSol(Password1, Password2);

            Console.WriteLine(Math.Pow(2,count));
        }
    }
}

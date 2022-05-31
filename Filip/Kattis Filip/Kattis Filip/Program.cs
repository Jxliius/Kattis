using System;

namespace Kattis_Filip
{
    internal class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            string[]A = Einlesen.Split(' ');

            string Z1 = ReverseString(A[0]);
            string Z2 = ReverseString(A[1]);

            if(Convert.ToInt32(Z1) > Convert.ToInt32(Z2))
            {
                Console.WriteLine(Z1);
            }
            else
            {
                Console.WriteLine(Z2);
            }

            
        }
    }
}

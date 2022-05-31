using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());

            string[]A = Einlesen.Split(' ');

            for(int i = 1; i <= Convert.ToInt32(A[2]); i++)
            {
                if (i % Convert.ToInt32(A[0]) == 0 && i % Convert.ToInt32(A[1]) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % Convert.ToInt32(A[0]) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % Convert.ToInt32(A[1]) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            } 
        }
    }
}

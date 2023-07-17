using System;

namespace Adding_Trouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            int zahl1 = Int32.Parse(arr[0]);
            int zahl2 = Int32.Parse(arr[1]);
            int zahl3 = Int32.Parse(arr[2]);

            if(zahl1 + zahl2 == zahl3)
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }
        }
    }
}

using System;

namespace Aaah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Line1 = Convert.ToString(Console.ReadLine());
            string Line2 = Convert.ToString(Console.ReadLine());

            if (Line1.Length >= Line2.Length)
            {
                Console.WriteLine("go");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

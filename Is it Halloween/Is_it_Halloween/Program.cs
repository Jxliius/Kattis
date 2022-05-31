using System;

namespace Is_it_Halloween
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            if(Eingabe == "OCT 31" | Eingabe == "DEC 25")
            {
                Console.WriteLine("yup");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
    }
}

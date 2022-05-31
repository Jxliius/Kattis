using System;

namespace Competition_Kattis_Fabi_1v1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());

            string[] Array = Eingabe.Split(' ');

            int EmptyBottels = Int32.Parse(Array[0]) + Int32.Parse(Array[1]);
            int Erg = 0;
            int c = Int32.Parse(Array[2]);

            while(EmptyBottels >= c)
            {
                EmptyBottels -= c;
                Erg++; 
                EmptyBottels++;
            }
            Console.WriteLine(Erg);
            
        }
    }
}

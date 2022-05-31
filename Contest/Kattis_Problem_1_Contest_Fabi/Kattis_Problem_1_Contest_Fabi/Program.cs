using System;

namespace Kattis_Problem_1_Contest_Fabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            string Eingabe2 = Convert.ToString(Console.ReadLine());
            string[] Array = Eingabe2.Split(' ');
            int Tag = 0;
            int Speicher = 100000;
            for (int i = 0; i < Array.Length; i++)
            {
               
                    if(Int32.Parse(Array[i]) < Speicher)
                    {        
                    Tag = Int32.Parse(Array[i]);
                    }
            }
            Console.WriteLine(Tag);
        }
    }
}

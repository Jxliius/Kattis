using System;

namespace Rocket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            string Eingabe2 = Convert.ToString(Console.ReadLine());
            string[] Array = Eingabe2.Split(' ');
            int Tag = 0;
            int min = 10000000;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Convert.ToInt32(Array[i]) < min)
                {
                    Tag = i;
                    min = Int32.Parse(Array[i]);
                }
            }
            Console.WriteLine(Tag);
        }
    }
}

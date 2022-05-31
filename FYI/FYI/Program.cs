using System;

namespace FYI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < 3; i++)
            {
                if(Einlesen[i] == '5')
                {
                    c++;
                }
                else
                {
                    i++;
                }
            }

            if(c == 3)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

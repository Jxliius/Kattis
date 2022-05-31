using System;

namespace Greetings_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Console.ReadLine());
            string erg = string.Empty;
            int count = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'e')
                {
                    count++;
                }
                
            }
            for (int i2 = 0; i2 < count * 2; i2++)
            {
                erg += 'e';
            }
            Console.WriteLine("h" + erg + "y");
        }
    }
}

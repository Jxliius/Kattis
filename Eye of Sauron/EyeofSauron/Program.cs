using System;

namespace EyeofSauron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string b = Convert.ToString(Console.ReadLine());
            int c1 = 0;
            int c2 = 0;
            for(int i = 0; i < b.Length; i++)
            {
                if(b[i] != '(')
                {
                    c1 += 1;
                }
                else
                {
                    i = b.Length;
                }
            }
            for(int i = c1; i < b.Length; i++)
            {
                if(b[i] != ')')
                {
                    c2 += 1;
                }
                else
                {
                    i++;
                }
            }
            if(c1 == c2)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("fix");
            }
        }
    }
}

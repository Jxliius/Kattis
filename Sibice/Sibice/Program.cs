using System;

namespace Sibice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int matches = Convert.ToInt32(split[0]);
            int width = Convert.ToInt32(split[1]);
            int height = Convert.ToInt32(split[2]);
            string[] answarr = new string[matches];
            for(int i = 0; i < matches; i++)
            {
                int matchlength = Convert.ToInt32(Console.ReadLine());

                if(matchlength <= Math.Sqrt(Math.Pow(width,2) + Math.Pow(height, 2)))
                {
                    answarr[i] = "DA";
                }
                else
                {
                    answarr[i] = "NE";
                }
            }

            foreach(string s in answarr)
            {
                Console.WriteLine(s);
            }
        }
    }
}

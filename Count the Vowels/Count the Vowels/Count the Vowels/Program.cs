using System;

namespace Count_the_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            string Check = Eingabe.ToLower();
            int count = 0;
            for(int i = 0; i < Check.Length; i++)
            {
                if(Check[i] == 'a' | Check[i] == 'e' | Check[i] == 'i' | Check[i] == 'o' | Check[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

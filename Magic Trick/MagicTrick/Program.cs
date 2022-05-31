using System;

namespace MagicTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            int counter = 0;
            for(int i = 0; i < Eingabe.Length; i++)
            {
                for(int j = i + 1; j < Eingabe.Length; j++)
                {
                    if(Eingabe[i] == Eingabe[j])
                    {
                        counter++;
                    }
                }
            }
            if(counter > 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}

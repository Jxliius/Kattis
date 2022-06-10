using System;

namespace No_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());
            string[]Arr = Einlesen.Split(' ');
            string Wort = "";
            int count = 0;
            bool schalter = false;
            for(int i = 0; i < Arr.Length; i++)
            {
                Wort = Arr[i];

                for(int j = 0; j < Arr.Length; j++)
                {
                    if(Arr[j] == Wort)
                    {
                        count++;
                    }
                }
                if(count > 1)
                {
                    schalter = true;
                }
                count = 0;
            }
            if(schalter == true)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}

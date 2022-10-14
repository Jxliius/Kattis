using System;

namespace Turn_it_Up_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anzahl = Convert.ToInt32(Console.ReadLine());
            int Wert = 7;
            for (int i = 0; i < Anzahl; i++)
            {
                string Einlesen = Convert.ToString(Console.ReadLine());

               if(Einlesen == "Skru op!")
                {
                    if(Wert == 10)
                    {

                    }
                    else
                    {
                        Wert++;
                    }
                }
                else
                {
                    if(Wert == 0)
                    {

                    }
                    else
                    {
                        Wert--;
                    }
                }
            }
            Console.WriteLine(Wert);
        }
    }
}
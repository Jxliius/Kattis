using System;

namespace Kattis_Contest3_1v1v1_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = "";
            string[] Array = new string[11];

            for (int i = 0; i < 4; i++)
            {
                Eingabe += Convert.ToString(Console.ReadLine()) + " ";
            }
            Array = Eingabe.Split(' ');


            for (int i = 0; i < Array.Length; i++)
            {
                if(Array[i].Contains("3") == Array[i + 1].Contains("3") | Array[i].Contains("2") == Array[i + 1].Contains("2") | Array[i].Contains("1") == Array[i + 1].Contains("1"))
                {
                    Console.WriteLine(i + 1);
                }
                else if(Array[i].Contains("D") == Array[i + 1].Contains("D") | Array[i].Contains("S") == Array[i + 1].Contains("S") | Array[i].Contains("O") == Array[i + 1].Contains("O"))
                {
                    Console.WriteLine(i + 1);
                }
                else if(Array[i].Contains("R") == Array[i + 1].Contains("R") | Array[i].Contains("G") == Array[i + 1].Contains("G") | Array[i].Contains("P") == Array[i + 1].Contains("P"))
                {
                    Console.WriteLine(i + 1);
                }
                else
                {
                    Console.WriteLine("no sets");
                }
            }
        }
    }
}

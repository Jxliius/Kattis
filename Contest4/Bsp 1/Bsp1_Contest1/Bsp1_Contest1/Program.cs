using System;

namespace Bsp1_Contest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Eingabe = Convert.ToString(Console.ReadLine());
            string[] Array = new string[Eingabe.Length];
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = Convert.ToString(Eingabe[i]);
            }
            double tcounter = 0, ccounter = 0, gcounter = 0;
            double points = 0;

            for(int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Contains('T'))
                {
                    tcounter++;
                }
                if (Array[i].Contains('C'))
                {
                    ccounter++;
                }
                if (Array[i].Contains('G'))
                {
                    gcounter++;
                }
            }

            points = Math.Pow(tcounter, 2) + Math.Pow(ccounter, 2) + Math.Pow(gcounter,2) ;
            
            
                if(tcounter <= ccounter && tcounter <= gcounter)
                {
                    points += tcounter * 7;
                }
                else if(ccounter <= tcounter && ccounter <= gcounter)
                {
                    points += ccounter * 7;
                }
                else if(gcounter <= tcounter && gcounter <= ccounter)
                { 
                    points += gcounter * 7;
                }
           
          
            Console.WriteLine(points);
        }
    }
}

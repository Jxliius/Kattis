using System;

namespace Spavanac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Einlesen = Convert.ToString(Console.ReadLine());
            string[] split = Einlesen.Split(' ');
            int hours = Convert.ToInt32(split[0]);
            int minutes = Convert.ToInt32(split[1]);

            if (hours == 0)
            {
                hours = 24;
            }
            minutes = minutes + hours * 60;
            
            hours = 0;
            minutes -= 45;
            while (minutes > 60)
            {
                minutes -= 60;
                hours++;
            }
            if(hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine(hours + " " + minutes);
        }
    }
}

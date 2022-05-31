using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 0;

            if(time < 10)
            {
                while (time < 10)
                {
                    Console.WriteLine("Hallo");
                    time++;
                }
            }
            else
            {
                Console.WriteLine("Tschüss");
            }
            

        }
    }
}

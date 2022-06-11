using System;

namespace Fifty_Shades_of_Pink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anz = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string input = string.Empty;
            for(int i = 0; i < anz; i++)
            {
                input = Convert.ToString(Console.ReadLine());

                if(input.ToLower().Contains("pink") | input.ToLower().Contains("rose"))
                {
                    count++;
                }
            }
            if(count > 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }
        }
    }
}

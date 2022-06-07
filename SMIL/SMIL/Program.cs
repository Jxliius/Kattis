using System;

namespace SMIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                if(i == input.Length - 1)
                {
                    break;
                }
                if (input[i] == ':' | input[i] == ';')
                {
                    if (input[i + 1] == ')')
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        if (input[i + 1] == '-')
                        {
                            if (input[i + 2] == ')')
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            }
        }
    }
}

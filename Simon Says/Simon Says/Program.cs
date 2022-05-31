using System;

namespace Simon_Says
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anz = Convert.ToInt32(Console.ReadLine());
            string[] sol = new string[anz];

            for (int i = 0; i < anz; i++)
            {
                string Einlesen = Convert.ToString(Console.ReadLine());

                if (Einlesen.StartsWith("Simon says"))
                {
                    sol[i] = Einlesen.Substring(11);
                }
            }
            for(int i = 0; i < sol.Length; i++)
            {
                if (sol[i] != null)
                {
                    Console.WriteLine(sol[i]);
                }
            }
        }
    }
}

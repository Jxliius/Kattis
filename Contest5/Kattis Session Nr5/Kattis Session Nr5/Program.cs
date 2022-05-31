using System;

namespace Kattis_Session_Nr5
{
    internal class Program
    {
        static double[] getVal(double j, double h, double n)
        {

            double[] sol = new double[2];

            sol[0] = Math.Pow(j, 2) * Math.PI;

            sol[1] = (n / h) * ((j + j) * (j + j));

            return sol;
        }
        static void Main(string[] args)
        {

            string[] output = new string[1000];

            for (int i = 0; i < 1000; i++)
            {
                
                string n = Convert.ToString(Console.ReadLine());

                if (n == "0 0 0")
                {
                    output[i] = n;
                    break;
                }

                
                string[] u = n.Split(" ");
                double[] sol = getVal(Convert.ToDouble(u[0]), Convert.ToDouble(u[1]), Convert.ToDouble(u[2]));

                
                output[i] = sol[0] + " " + sol[1];
            }

            
            for (int i = 0; i < 1000; i++)
            {
                if (output[i] == "0 0 0")
                {
                    break;
                }

                
                Console.WriteLine(output[i]);
            }

        }
    }
}

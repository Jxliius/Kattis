﻿using System;
using System.Transactions;

namespace AboveAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anz = Convert.ToInt32(Console.ReadLine());
            double[] sol = new double[anz];
            for (int i = 0; i < anz; i++)
            {
                double durchschnitt = 0;
                double overdurchschnitt = 0;
                bool durchschnittberechnet = false;

                string eingabe = Console.ReadLine();
                string[] split = eingabe.Split(' ');
                for (int j = 1; j <= Double.Parse(split[0]); j++)
                {
                    if (durchschnittberechnet)
                    {
                        if (Double.Parse(split[j]) > durchschnitt)
                        {
                            overdurchschnitt++;
                        }
                        if (j == Double.Parse(split[0]))
                        {
                            sol[i] = overdurchschnitt * (100 / Double.Parse(split[0]));
                        }
                    }
                    if (!durchschnittberechnet)
                    {
                        durchschnitt += Double.Parse(split[j]);
                    }
                    if (j == Double.Parse(split[0]))
                    {
                        if (!durchschnittberechnet)
                        {
                            j = 0;
                            durchschnitt /= Double.Parse(split[0]);
                            durchschnittberechnet = true;
                        }
                    }

                }
            }
            foreach(double i in sol)
            {
                Console.WriteLine(string.Format("{0:f3}", i) + "%");
            }
        }
    }
}

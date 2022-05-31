using System;

namespace SpeedLimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Erg = 0;
            int zwischenspeicher = 0;
            int[] Ar = new int[10];
            int count = 0;
            Benutzereingabe:
            int Anz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Anz; i++)
            {
                if (Anz == -1)
                {
                    break;
                }
                string eingabe = Convert.ToString(Console.ReadLine());
                string[] A = eingabe.Split(' ');


                int timeinh = Convert.ToInt32(A[1]) - zwischenspeicher;
                Erg += Convert.ToInt32(A[0]) * timeinh;
                zwischenspeicher = Convert.ToInt32(A[1]);

                if (Anz == i + 1)
                {

                    zwischenspeicher = 0;
                    if (Ar[count] != 0)
                    {
                        Ar[count + 1] = Erg;
                        count++;
                        Erg = 0;
                    }
                    else
                    {
                        Ar[count] = Erg;
                        count++;
                        Erg = 0;
                    }
                }

            }
            if (Anz == -1)
            {
                for (int i = 0; i < Ar.Length; i++)
                {
                    if (Ar[i] != 0)
                    {
                        Console.WriteLine(Ar[i] + " " + "miles");
                    }

                }
            }
            else
            {
                goto Benutzereingabe;
            }
        }
    }
}

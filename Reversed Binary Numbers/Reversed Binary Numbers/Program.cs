using System;
using System.Threading;

namespace Reversed_Binary_Numbers
{
    internal class Program
    {

        static string BinaryChange(int number)
        {
            string binary = string.Empty;
            for(int i = 0; number > 0; i++)
            {
                binary += number % 2;
                number /= 2;
            }
            return binary;
        }
        static double ChangeBack(string binarynum)
        {
            double res = 0;
            for(int i = 0; i < binarynum.Length; i++)
            {
                res += Int32.Parse(Convert.ToString(binarynum[i])) * Math.Pow(2, i);
            }
            return res;
        }
        static string ReverseString(string binarynum)
        {
            char[] chararr = binarynum.ToCharArray();
            Array.Reverse(chararr);
            return new string(chararr);
        }
        static void Main(string[] args)
        {
            //Get Input
            int number = Convert.ToInt32(Console.ReadLine());
            //Make the number to a Binary string
            string binarynumber = BinaryChange(number);
            //Reverse Binary
            binarynumber = ReverseString(binarynumber);
            //Get the result
            double res = ChangeBack(binarynumber);
            Console.WriteLine(res);


        }
    }
}

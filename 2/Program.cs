using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, neg=0, poz=0, zero=0;

            Console.Write("n=");
            n=Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                x=Convert.ToInt32(Console.ReadLine());
                if (x == 0) zero = zero + 1;
                else if (x > 0) poz = poz + 1;
                else neg = neg + 1;
                n--;
            }
            Console.WriteLine("{0} numere au fost negative, {1} numere erau pozitive si {2} era zero", neg, poz, zero);
        }
    }
}
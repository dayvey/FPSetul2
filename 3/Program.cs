using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0, prod = 1;

            Console.Write("n=");
            n=Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                sum += i;
                prod *= i;
            }

            Console.WriteLine("Suma numerelor de la 1 la n este {0} si produsul este {1}", sum, prod);
        }
    }
}
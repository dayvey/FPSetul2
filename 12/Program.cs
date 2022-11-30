using System;
using System.Security.Cryptography.X509Certificates;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int num = 0, ant = 0;
            int x = 0, y = 0;

            for (int i=1; i<=n; i++)
            {
                y = x;
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                    if (ant != 0)
                        num++;
                ant = x;
            }
            if (x != 0)
                num++;
            Console.WriteLine("{0} grupuri de numere consecutive sunt diferite de zero", num);
        }
    }
}
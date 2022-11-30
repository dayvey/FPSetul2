using System;
using System.Security.Cryptography;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int c = 0, x = 0, y = 0, i=1;
            x = int.Parse(Console.ReadLine());
            int c2 = 0;

            for (i = 1; i < n && c < 1; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)
                    c++;
                else 
                    c2 = 1;
                x = y;
            }

            y = int.Parse(Console.ReadLine());
            if (x < y && c2 == 0)
                c++;
            else
            {
                x = y;
                i++;
            }

            if (c != 0)
            {
                for (int j=i; i < n && c<2; i++)
                {
                    y=int.Parse(Console.ReadLine());
                    if (x > y)
                        c++;
                    x = y;
                }
            }
            if (c != 1)
                Console.WriteLine("Secventa data NU este o secventa bitonica rotita!");
            else Console.WriteLine("Secventa data este o secventa bitonica rotita!");
        }
    }
}
using System;
using System.Globalization;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int x=Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int i = 1;

            if (x > y)
                c = 2;

            for (i = 2; i < n && c == 0; i++)
            {
                y=Convert.ToInt32(Console.ReadLine());
                if (x > y)
                    c = 1;
                x = y;

            }

            if (c!=2)
                if (i == n)
                    c = 1;
                else c = 0;

            for (int j = i; j < n && c==0; j++)
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (x < y)
                    c = 1;
                x = y;
            }
            if (c == 0) Console.WriteLine("Secventa data este o secventa bitonica.");
            else Console.WriteLine("Secventa data NU este o secventa bitonica.");
        }
    }
}
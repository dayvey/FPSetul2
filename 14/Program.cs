using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            if (x > y)
            {
                x = y;
                for (int i = 2; i < n; i++)
                {
                    y=Convert.ToInt32(Console.ReadLine());
                    if (x < y)
                        c++;
                    x = y;
                }
                if (c <= 1) Console.WriteLine("Secventa data este o secventa monotona rotita.");
                else Console.WriteLine("Secventa data NU este o secventa monotona rotita.");
            }
            else
            {
                x = y;
                for (int i = 2; i < n; i++)
                {
                    y = Convert.ToInt32(Console.ReadLine());
                    if (x > y)
                        c++;
                    x = y;
                }
                if (c <= 1) Console.WriteLine("Secventa data este o secventa monotona rotita.");
                else Console.WriteLine("Secventa data NU este o secventa monotona rotita.");
            }
        }
    }
}
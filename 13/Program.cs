using System;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int x=int.Parse(Console.ReadLine());
            int y = 0;
            int c = 0;

            for (int i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)
                    c++;
                x = y;
            }
            if (c <= 1) Console.WriteLine("Secventa data este o secventa crescatoare rotita.");
            else Console.WriteLine("Secventa data NU este o secventa crescatoare rotita.");
        }
    }
}
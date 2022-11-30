using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x, y, z=0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            if (n == 0)
                Console.WriteLine("Al {0}-lea numar din sirul Fibonacci este 0", n);
            else if (n == 1) Console.WriteLine("Al {0}-lea numar din sirul Fibonacci este 1", n);
            else
            {
                x = 0; y = 1;
                for (int i=2; i<=n; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;
                }
            }
            Console.WriteLine("Al {0}-lea numar din sirul Fibonacci este {1}", n, z);
        }
    }
}
using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i=1; i<=n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = 0;
                while (x > 0)
                {
                    y = y * 10 + x % 10;
                    x /= 10;
                }
                sum += y;
            }
            Console.WriteLine("Suma inverselor din secventa data de n numere este {0}", sum);
        }
    }
}
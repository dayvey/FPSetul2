using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int x, y, max, nr;
            x = Convert.ToInt32(Console.ReadLine());
            nr = 1;
            max = 0;

            for (int i=2; i<=n; i++)
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (x != y)
                {
                    if (max < nr)
                        max = nr;
                    nr = 1;
                }
                else nr++;
                x = y;
            }
            if (max < nr)
                max = nr;
            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este {0}", max);
        }
    }
}
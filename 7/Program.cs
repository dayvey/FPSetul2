using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, max, min;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());
            max = x; min = x;

            for (int i=1; i<=n-1; i++)
            {
                x=int.Parse(Console.ReadLine());
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }
            Console.WriteLine("Cea mai mare valoare este {0} si cea mai mica valoare este {1}", max, min);
        }
    }
}
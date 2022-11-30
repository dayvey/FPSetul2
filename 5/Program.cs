using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, nr = 0, x;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == i) nr++;
            }
            Console.WriteLine("{0} numere erau egale cu pozitia pe care au aparut", nr);
        }
    }
}
using System;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, n;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            bool c = true;
            if (x > y)
            {
                for (int i = 3; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (y < x)
                        c = false;
                    y = x;
                }
                if (c == true)
                    Console.WriteLine("Sirul este monoton descrescatoare.");
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (y > x)
                        c = false;
                    y = x;
                }
                if (c == true)
                    Console.WriteLine("Sirul este monoton crescatoare.");
            }
            if (c == false)
                Console.WriteLine("Sirul nu este nici monoton crescatoare, nici monoton descrescatoare.");
        }
    }
}
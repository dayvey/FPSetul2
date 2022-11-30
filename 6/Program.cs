using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            bool c = true;

            int y=Convert.ToInt32(Console.ReadLine());
            n--;

            for (int i=0; i<n; i++)
            {
                int x=Convert.ToInt32(Console.ReadLine());
                if (y > x)
                    c = false;
                y = x;
            }
            if (c == false)
                Console.WriteLine("Nu sunt in ordine crescatoare.");
            else Console.WriteLine("Sunt in ordine crescatoare.");
        }
    }
}
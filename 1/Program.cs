using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());

            int num = 0;
            while (n>0)
            {
                x=int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    num++;
                n -= 1;
            }

            Console.Write("{0} numere au fost pare.", num);
        }
    }
}
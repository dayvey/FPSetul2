using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());

            int i=0;
            bool c = true;
            int j = 0;

            while (n>0)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == a)
                {
                    c = false;
                    j = i;
                }
                else
                {
                    i++;
                }
                n--;
            }
            if (c == true) Console.WriteLine("Numarul a nu era in secventa data (-1)");
            else Console.WriteLine("Numarul a era pe pozitia {0}", j);
        }
    }
}
using System;
using System.Xml.Schema;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int maxinc = 0, desc = 0, inc = 0, x = 0, c = 0;

            if (n % 2 != 0)
            {
                c = 1;
            }
            else
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                    c = 1;
                else desc++;
            }

            for (int i = 1; i < n && c==0; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    if (maxinc < (desc - inc))
                        maxinc = desc - inc;
                    inc++;
                }
                else desc++;
            }

            if (c == 1 || inc != desc)
                Console.WriteLine("Secventa nu reprezinta o secventa de paranteze corecta");
            else Console.WriteLine("Secventa reprezinta o secventa de paranteze corecta si nivelul maxim de incuibare a parantezelor este {0}", maxinc);
        }
    }
}
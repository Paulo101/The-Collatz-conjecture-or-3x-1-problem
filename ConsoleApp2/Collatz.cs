using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Collatz
    {
        public static void Collazt(int n)
        {
            if (n % 2 != 0)
                Console.WriteLine(n);

            if ((n % 2) == 0)
            {
                n = n / 2;
            }
            else
            {
                n = (n * 3) + 1;
            }

            if (n != 1)
                Collazt(n);
            else
                Console.WriteLine(n);
        }
    }
}

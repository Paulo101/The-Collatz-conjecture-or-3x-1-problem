using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Collatz
    {
        public static List<int> Collazt(int n)
        {
            List<int> data = new List<int>();
            data.Add(n);

            int resul = 0;

            while (true)
            {

                if (n == 1)
                {
                    break;
                }
                if ((n % 2) == 0)
                {
                    resul = n / 2;
                    n = resul;

                }
                else
                {
                    resul = (n * 3) + 1;
                    n = resul;
                }
                if (n % 2 != 0)
                    data.Add(n);
            }

            return data;
        }
    }
}

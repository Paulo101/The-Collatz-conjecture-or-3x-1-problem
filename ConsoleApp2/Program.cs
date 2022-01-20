


using ConsoleApp2;
using System;

namespace ConsoleApp2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("N: ");
            string s = Console.ReadLine();
            if(string.IsNullOrEmpty(s))
                Main(args);
            int r = int.Parse(s);
            List<int> list = Collatz.Collazt(r);

            Print(list);
        }
        static void Print(List<int> _list)
        {
            foreach (var item in _list)
                Console.WriteLine(item);
        }
    }
}

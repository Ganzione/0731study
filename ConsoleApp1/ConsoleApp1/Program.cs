using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");

            Console.WriteLine();
            Console.WriteLine();

            int i1 = 3;
            string s1 = "Hi";

            Console.WriteLine(i1 + " " + s1);
            Console.WriteLine("{0} {1}", i1, s1);
            Console.WriteLine(@i1 + " " + s1);
            Console.ReadKey();
        }
    }
}

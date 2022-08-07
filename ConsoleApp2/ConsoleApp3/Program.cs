using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

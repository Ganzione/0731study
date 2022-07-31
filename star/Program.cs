using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeStar();
            Console.ReadKey();
        }

        static void MakeStar()
        {
            int a, b, c, d, e;

            for (a = 5; a > 0; a--)
            {
                for (b = 5; b > 5-a; b--)
                {
                    Console.Write("*");
                }
                for (c = 0; c < 5-a; c++)
                {
                    Console.Write(" ");
                } // 왼쪽 위 직각삼각형
                for (d = 5; d > a; d--)
                {
                    Console.Write(" ");
                }
                for (e = 5; e > 5 - a; e--)
                {
                    Console.Write("*");
                } //오른쪽 위 직각삼각형
                Console.WriteLine();
            }
        }
    }
}

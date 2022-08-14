using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testing();
        }

        static void testing()
        {
            int win = 0;
            game1(ref win);
            while (true)
            {
                Console.Write("다시 하시겠습니까? (Y/N): ");
                string b = Console.ReadLine();
                if (b == "y" || b == "Y")
                {
                    game1(ref win);
                    continue;
                }
                if (b == "n" || b == "N")
                {
                    Console.Write("게임을 종료합니다. ");
                    Console.WriteLine("총 {0}번 승리하셨습니다.", win);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("입력을 확인하지 못했습니다.");
                    continue;
                }
            }
        }

        static void game1(ref int win)
        {
            Random random = new Random();

            while (true)
            {
                int i = random.Next(1, 9);

                Console.Write("홀 또는 짝 중에 하나를 적어주십시오: ");
                string a = Console.ReadLine();

                if (a == "짝")
                {
                    if (i % 2 == 0)
                    {
                        win++;
                        Console.WriteLine("컴퓨터의 선택: 짝");
                        Console.WriteLine("승리!");
                        break;
                    }
                    else //사용자가 짝을 입력했을 때, 컴퓨터가 홀수를 골랐을 시
                    {
                        Console.WriteLine("컴퓨터의 선택: 홀");
                        Console.WriteLine("패배!");
                        break;
                    }
                }

                if (a == "홀")
                {
                    if (i % 2 != 0)
                    {
                        win++;
                        Console.WriteLine("컴퓨터의 선택: 홀");
                        Console.WriteLine("승리!");
                        break;
                    }
                    else //사용자가 홀을 입력했을 때, 컴퓨터가 짝수를 골랐을 시
                    {
                        Console.WriteLine("컴퓨터의 선택: 짝");
                        Console.WriteLine("패배!");
                        break;
                    }
                }
            }
        }
    }
}

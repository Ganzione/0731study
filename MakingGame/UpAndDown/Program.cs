using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDown
{
    class Program
    {
        static void Main(string[] args)
        {
            randoms();
            while (true)
            {
                Console.Write("다시 하시겠습니까? (Y/N): ");
                string b = Console.ReadLine();
                if (b == "y" || b == "Y")
                {
                    randoms();
                    continue;
                }
                if (b == "n" || b == "N")
                {
                    Console.Write("게임을 종료합니다.");
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
        static void randoms()
        {
                Random ran = new Random();
                int NumTry = 0;
                int Answer = ran.Next(1, 501);
                while (true)
                {
                    Console.Write("1~500의 숫자 중 하나를 입력해주세요: ");
                    string input = Console.ReadLine();
                    int guess = int.Parse(input);
                    if (guess > Answer)
                    {
                        NumTry++;
                        Console.WriteLine("더 작아야합니다.");
                        continue;
                    }
                    if (guess < Answer)
                    {
                        NumTry++;
                        Console.WriteLine("더 커야합니다.");
                        continue;
                    }
                    if (guess == Answer)
                    {
                        NumTry++;
                        Console.WriteLine("정답입니다!");
                        Console.WriteLine("총 {0}라운드를 진행하셨습니다.", NumTry);
                        break;
                    }
                }
        }
    }
}

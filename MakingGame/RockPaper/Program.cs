using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testing();
        }
        static void testing()
        {
            int wining = 0;
            int same = 0;
            game1(ref wining, ref same);
            while (true)
            {
                Console.Write("다시 하시겠습니까? (Y/N): ");
                string b = Console.ReadLine();
                if (b == "y" || b == "Y")
                {
                    game1(ref wining, ref same);
                    continue;
                }
                if (b == "n" || b == "N")
                {
                    Console.Write("게임을 종료합니다. ");
                    Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, wining);
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
        static void game1(ref int wining, ref int same)
        {
            Random random = new Random();

            while (true)
            {
                int i = random.Next(1, 4); // 1~3을 컴퓨터가 선택함. 1=가위 2=바위 3=보

                Console.Write("가위 바위 보 중에 하나를 선택해주십시오: ");
                string a = Console.ReadLine();

                if (a == "가위")
                {
                    if (i == 1) // 컴퓨터가 가위를 냈을 시
                    {
                        same++; //비긴 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("무승부!");
                        break;
                    }
                    if (i == 3) // 컴퓨터가 보를 골랐을 시
                    {
                        wining++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 보");
                        Console.WriteLine("승리!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("컴퓨터의 선택: 바위");
                        Console.WriteLine("패배!");
                        break;
                    }
                }

                if (a == "바위")
                {
                    if (i == 2) // 컴퓨터가 바위를 냈을 시
                    {
                        same++; //비긴 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 바위");
                        Console.WriteLine("무승부!");
                        break;
                    }
                    if (i == 1) // 컴퓨터가 가위를 골랐을 시
                    {
                        wining++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("승리!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("컴퓨터의 선택: 보");
                        Console.WriteLine("패배!");
                        break;
                    }
                }

                if (a == "보")
                {
                    if (i == 3) // 컴퓨터가 보를 냈을 시
                    {
                        same++; //비긴 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 보");
                        Console.WriteLine("무승부!");
                        break;
                    }
                    if (i == 2) // 컴퓨터가 바위를 골랐을 시
                    {
                        wining++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 바위");
                        Console.WriteLine("승리!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("패배!");
                        break;
                    }
                }
            }
        }
    }
}
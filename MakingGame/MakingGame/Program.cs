﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.Clear();
            Console.WriteLine("미니 랜드에 오신 것을 환영합니다. 플레이 하실 게임을 선택해주세요.");
            Console.WriteLine("1. 홀짝 게임");
            Console.WriteLine("2. 가위바위보 게임");
            Console.WriteLine("3. 업앤다운 게임");
            Console.WriteLine("4. 게임 완전 종료");
            while (true)
            {
                Console.Write("해당하는 숫자를 입력해주세요: ");
                string Number = Console.ReadLine();
                int Number2 = int.Parse(Number);
                if (Number2 == 1)
                {
                    oddoreven();
                    break;
                }
                if (Number2 == 2)
                {
                    RockPaper();
                    break;
                }
                if (Number2 == 3)
                {
                    upanddown();
                    break;
                }
                if (Number2 == 4)
                {
                    Console.WriteLine("게임을 완전히 종료합니다.");
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

        static void oddoreven()
        {
            int win = 0;
            int lose = 0;
            game1(ref win, ref lose);
            while (true)
            {
                Console.Write("다시 하시겠습니까? (Y/N): ");
                string b = Console.ReadLine();
                if (b == "y" || b == "Y")
                {
                    game1(ref win, ref lose);
                    continue;
                }
                if (b == "n" || b == "N")
                {
                    Console.WriteLine("총 {0}번 패배, {1}번 승리하셨습니다.",lose, win);
                    Console.WriteLine("게임 선택 화면으로 돌아갑니다.");
                    Start();
                    break;
                }
                else
                {
                    Console.WriteLine("입력을 확인하지 못했습니다.");
                    continue;
                }
            }
        }

        static void game1(ref int win, ref int lose)
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
                        lose++;
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
                        lose++;
                        Console.WriteLine("컴퓨터의 선택: 짝");
                        Console.WriteLine("패배!");
                        break;
                    }
                }
            }
        }


        static void RockPaper()
        {
            int wining = 0;
            int same = 0;
            int losing = 0;
            game2(ref wining, ref same, ref losing);
            while (true)
            {
                Console.Write("다시 하시겠습니까? (Y/N): ");
                string b = Console.ReadLine();
                if (b == "y" || b == "Y")
                {
                    game2(ref wining, ref same, ref losing);
                    continue;
                }
                if (b == "n" || b == "N")
                {
                    Console.WriteLine("총 {0}번 비기고, {1}번 패배, {2}번 승리하셨습니다.", same, losing, wining);
                    Console.WriteLine("게임 선택 화면으로 돌아갑니다.");
                    Start();
                    break;
                }
                else
                {
                    Console.WriteLine("입력을 확인하지 못했습니다.");
                    continue;
                }
            }
        }
        static void game2(ref int wining, ref int same, ref int losing)
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
                        losing++;
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
                        losing++;
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
                        losing++;
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("패배!");
                        break;
                    }
                }
            }
        }

        static void upanddown()
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
                    Console.WriteLine("게임 선택 화면으로 돌아갑니다.");
                    Start();
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
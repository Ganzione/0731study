using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력해주세요: ");
            string a = Console.ReadLine();
            int a1 = int.Parse(a);

            string answer2 = "y";

            while (answer2 == "y" || answer2 == "Y")
            {
                Game(a1);
                Console.Write("계속하시겠습니까? (Y/N): ");
                answer2 = Console.ReadLine();

                if (answer2 == "n" || answer2 == "N")
                {
                    Console.Write("종료합니다.");
                } 
            }
            Console.ReadKey();
        }

        static void Game(int a1)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();

            Console.Write(randomNumber + "은 " + a1 + "의 배수입니까? (Y/N): ");
            string answer = Console.ReadLine();

            if (randomNumber % a1 == 0 && (answer == "Y" || answer == "y"))
            {
                stopwatch.Stop();
                Console.WriteLine("소요된 시간은 " + stopwatch.ElapsedMilliseconds / 1000 + "초 입니다.");
            }
            else if (randomNumber % a1 != 0 && (answer == "n" || answer == "N"))
            {
                stopwatch.Stop();
                Console.WriteLine("소요된 시간은 " + stopwatch.ElapsedMilliseconds / 1000 + "초 입니다.");
            }
            else
            {
                Console.WriteLine("오답입니다.");
            }
        }
    }
}

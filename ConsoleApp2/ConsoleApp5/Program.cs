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
            //스위칭

            string[] sname = new string[5];
            string temp;

            //김인숙 김준겸 김지원 박현웅 정진경 - 퍼문
            //김인숙 김지원 김준겸 박현웅 정진경 - 퍼문
            //김인숙 김지원 김준겸
            //김인숙 김지원 김준겸 박현웅
            //김인숙 김지원 김준겸 박현웅 정진경 

            sname[0] = "김지원";
            sname[1] = "김준겸";//나잘해
            sname[2] = "박현웅";
            sname[3] = "김인숙";
            sname[4] = "정진경";

            for (int i = 0; i < sname.Length; i++)
            {
                for (int j = 0; j < sname.Length; j++)
                {

                    if (sname[i][0] < sname[j][0])
                    {
                        temp = sname[i]; //김준겸
                        sname[i] = sname[j];
                        sname[j] = temp;
                    }

                    else if (sname[i][0] == sname[j][0] && sname[i][1] < sname[j][1])
                    {
                        temp = sname[i]; //김준겸
                        sname[i] = sname[j];
                        sname[j] = temp;
                    }

                    else if (((sname[i][0] == sname[j][0]) && (sname[i][1] == sname[j][1])) && (sname[i][2] < sname[j][2]))
                    {
                        temp = sname[i]; //김준겸
                        sname[i] = sname[j];
                        sname[j] = temp;
                    }
                }
            }

            System.Console.WriteLine(sname[0]);
            System.Console.WriteLine(sname[1]);
            System.Console.WriteLine(sname[2]);
            System.Console.WriteLine(sname[3]);
            System.Console.WriteLine(sname[4]);
            Console.ReadKey();
        }
    }
}
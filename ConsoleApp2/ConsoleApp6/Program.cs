using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("사과");
            myList.Add("배");
            myList.Add("수박");
            myList.Add("복숭아");
            myList.Add("포도");
            myList.RemoveAt(3);

            Console.WriteLine(myList[3]);
            Console.ReadLine();
        }
    }
}

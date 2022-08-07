using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int>
                myDict = new Dictionary<string, int>();
            myDict["수박"] = 1;
            myDict["감자"] = 100;
            Console.WriteLine(myDict["감자"]);
            Console.ReadKey();
        }
    }
}

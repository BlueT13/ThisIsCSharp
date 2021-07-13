using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter2
{
    class Hello
    {
        //프로그램 실행이 시작되는 곳
        public static void PrintHello(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}

using System;

namespace Chapter05
{
    class While
    {
        public static void PrintWhile(string[] args)
        {
            int i = 10;

            while (i>0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}

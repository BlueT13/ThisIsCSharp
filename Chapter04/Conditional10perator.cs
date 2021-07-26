using System;

namespace Chapter04
{
    class Conditional10perator
    {
        public static void PrintConditional10perator(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}

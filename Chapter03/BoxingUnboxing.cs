using System;

namespace Chapter03
{
    class BoxingUnboxing
    {
        public static void PrintBoxingUnboxing(string[] args)
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}

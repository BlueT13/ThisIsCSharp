using System;

namespace Chapter06
{
    class SwapByRef
    {
        public static void Swqp(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}

using System;

namespace Chapter06
{
    class UsingOut
    {
        public static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}

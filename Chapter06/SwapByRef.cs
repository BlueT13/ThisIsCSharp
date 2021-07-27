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
            //함수를 호출할 때, 어떤 값을 함수 내부동작으로 바꾸고 싶을 때 ref를 사용한다.
        }
    }
}

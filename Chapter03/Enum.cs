using System;

namespace Chapter03
{
    class Enum
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK}
        public static void PrintEnum(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}

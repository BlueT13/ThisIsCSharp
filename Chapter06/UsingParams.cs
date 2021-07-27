using System;

namespace Chapter06
{
    class UsingParams
    {
        public static int Sum(params int[] args)
        {
            Console.WriteLine("Summing... ");
            int sum = 0;

            for(int i=0; i<args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                
                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }
    }
}

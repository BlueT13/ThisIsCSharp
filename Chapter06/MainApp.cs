using System;

namespace Chapter06
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);
            
            Console.WriteLine($"{Return.Fibonacci(10)}");

            Return.PrintProfile("", "123-4567");
            Return.PrintProfile("박상현", "456-1230");

            int x = 3;
            int y = 4;
            Console.WriteLine($"{x}, {y}");
            SwapByRef.Swqp(ref x, ref y);
            Console.WriteLine($"{x}, {y}");
            //
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");
        }
    }
}

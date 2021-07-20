using System;

namespace Chapter6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int result = Chapter6.Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            result = Chapter6.Return.Fibonacci(10);
            Console.WriteLine($"10번째 피보나치 수 : {result}");

            Chapter6.Return.PrintProfile("", "123-4567");
            Chapter6.Return.PrintProfile("박상현", "456-1230");
        }
    }
}

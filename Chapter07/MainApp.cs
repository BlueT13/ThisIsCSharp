using System;
using static System.Console;

namespace Chapter07
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}" );

            Cat nero = new Cat();
			nero.Color = "검은색";
			nero.Name = "네로";
			nero.Meow();
			WriteLine($"{nero.Name} : {nero.Color}");
			
			//
			
			Console.WriteLine($"Global.Count : {Global.Count}");

			new ClassA();
			new ClassA();
			new ClassB();
			new ClassB();

			Console.WriteLine($"Global.Count : {Global.Count}");
			
			//


		}
    }
}

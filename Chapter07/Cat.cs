using System;
using static System.Console;

namespace Chapter07
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            WriteLine($"{Name} : 야옹");
        }
    }
}

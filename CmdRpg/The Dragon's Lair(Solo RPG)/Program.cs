using System;

namespace The_Dragon_s_Lair_Solo_RPG_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void ColorWriter(ConsoleColor color, string whatToWrite)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(whatToWrite + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;

            Console.Write("Введите свое имя : ");
            name = Console.ReadLine();

            Console.Write("Введите любой символ : ");
            symbol = Console.ReadLine();

            Console.WriteLine("\n" + name);
            Console.WriteLine("\n" + symbol);
            Console.WriteLine("");
            for (int i = 0; i < name.Length + 2; i++)
            {
                Console.Write(symbol);
            }
            
            Console.WriteLine($"\n{symbol}{name}{symbol}");

            for (int i = 0; i < name.Length + 2; i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}

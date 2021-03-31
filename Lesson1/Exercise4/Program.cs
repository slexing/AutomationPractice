using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First string: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Second string: ");
            string second = Console.ReadLine();
            Console.WriteLine("Enter Char: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            var sum = first +" "+second;
            var index = sum.LastIndexOf(symbol);

            Console.WriteLine($"Concatenation string is {sum}");
            Console.WriteLine($"Index of {symbol} on {sum}:{index}");
            Console.ReadKey();

        }
    }
}

using System;


namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First string:");
            String first = Console.ReadLine();
            Console.WriteLine("Enter Second string:");
            String second = Console.ReadLine();
            Console.WriteLine("Enter third string:");
            String third = Console.ReadLine();

            String firstUpperCase = first.ToUpper();
            String secondUpperCase = second.ToUpper();
            String thirdUpperCase = third.ToUpper();
                 
            Console.WriteLine($"String {firstUpperCase} starts from {secondUpperCase}: {firstUpperCase.StartsWith(secondUpperCase)}");
            Console.WriteLine($"String {firstUpperCase} ends with {thirdUpperCase}: {firstUpperCase.EndsWith(thirdUpperCase)}");
            Console.ReadKey();
        }
    }
}

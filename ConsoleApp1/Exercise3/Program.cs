using System;


namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            String first = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            String second = Console.ReadLine();
            Console.WriteLine("Введите третью строку:");
            String third = Console.ReadLine();

            String firstLowerCase = first.ToLower();
            String secondLowerCase = second.ToLower();
            String thirdLowerCase = third.ToLower();

            //Method for startWith First to Second
            bool CompareFirstSecond()
            {
                return firstLowerCase.StartsWith(secondLowerCase);
            }
            // Method for endWith first to third
            bool CompareFirstThird()
            {
                return firstLowerCase.EndsWith(thirdLowerCase);
            }
                  
            Console.WriteLine($"String {firstLowerCase} starts from {secondLowerCase}: {CompareFirstSecond()}");
            Console.WriteLine($"String {firstLowerCase} ends with {thirdLowerCase}: {CompareFirstSecond()}");
            Console.ReadKey();
        }
    }
}

using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your x number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your y number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your z number:");
            int z = Convert.ToInt32(Console.ReadLine());

            int first = (x + y) * (z * z + 1);

            double second = (x % z - 1) * Math.Sqrt(y);

            double third = ((x * y) + (y * z)) / z * z * z;

            Console.WriteLine($"First expression result: {first}");
            Console.WriteLine($"Second expression result: {second}");
            Console.WriteLine($"Third expression result: {third}");
            Console.ReadKey();
        }
    }
}

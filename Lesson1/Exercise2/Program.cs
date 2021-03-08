using System;


namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                Console.WriteLine("Set long value: ");
                var side1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Set width value: ");
                var side2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Set height value: ");
                var side3 = Convert.ToInt32(Console.ReadLine());
            
                var shape = new Shape(side1, side2, side3);
                if (shape.ValidateSides(side1, side2, side3))
                {
                    double d = shape.CalculateDiagonal();
                    Console.WriteLine($"Диагональ пареллепипеда равна: {d}");
                    Console.ReadKey();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}

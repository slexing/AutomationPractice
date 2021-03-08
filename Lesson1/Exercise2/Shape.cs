using System;

namespace Exercise2
{
    class Shape
    {

         //Constructor
        public Shape(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        // Create property
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        //Method for Validate sides. Catch exception.
        public bool ValidateSides(int side1, int side2, int side3)
        {
            try
            {
                ThrowArgumentException(side1);
                ThrowArgumentException(side2);
                ThrowArgumentException(side3);

                return true;
            }
            catch (ArgumentException e)
            {
                throw;
            }
        }
        //Method for zero check
        private void ThrowArgumentException(int side)
        {
            if (side <= 0)
            {
                throw new ArgumentException();
            }

        }

        //Method Calculate Diagonal
        public double CalculateDiagonal()
        {
            return Math.Sqrt(Side1 * Side1 + Side2 * Side2 + Side3 * Side3);
        }

    }
}

    





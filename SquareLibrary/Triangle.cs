using System;

namespace SquareLibrary
{
    public class Triangle
    {
        public double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public bool IsRectangular(double a, double b, double c)
        {
            return (a*a + b*b == c*c) ||
                    (a*a + c*c == b*b) ||
                    (b*b + c*c == a*a);
        }
    }
}

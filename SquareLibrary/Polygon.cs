using System;

namespace SquareLibrary
{
    public class Polygon
    {
        /// <summary>
        /// Нахождение площади правильного многоугольника
        /// </summary>
        public double GetArea(int sideCount, double sideLength)
        {
            double result = (sideCount * Math.Pow(sideLength, 2)) /
                (4 * (Math.Tan((180 / sideCount) / (180 / Math.PI)))); // 180 / Math.PI - так как Math.Tan принимает в себя значение в радианах

            // округление
            return Math.Round(result, 2);
        }
    }
}

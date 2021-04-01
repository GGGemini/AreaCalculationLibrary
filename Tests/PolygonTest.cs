using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLibrary;
using System;

namespace Tests
{
    [TestClass]
    public class PolygonTest
    {
        Polygon polygon;

        double correct;
        double result;

        public PolygonTest()
        {
            polygon = new Polygon();
        }

        [TestMethod]
        public void GetAreaTest()
        {
            #region ТРЕУГОЛЬНИК
            correct = 0.43;
            result = polygon.GetArea(3, 1);
            if (result != correct)
            {
                throw new Exception($"Ответ: {result}. Правильный ответ: {correct}");
            }
            #endregion

            #region ЧЕТЫРЁХУГОЛЬНИК
            correct = 1;
            result = polygon.GetArea(4, 1);
            if (result != correct)
            {
                throw new Exception($"Ответ: {result}. Правильный ответ: {correct}");
            }
            #endregion

            #region ПЯТИУГОЛЬНИК
            correct = 1.72;
            result = polygon.GetArea(5, 1);
            if (result != correct)
            {
                throw new Exception($"Ответ: {result}. Правильный ответ: {correct}");
            }
            #endregion
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLibrary;
using System;

namespace Tests
{
    [TestClass]
    public class TriangleTest
    {
        Triangle circle;

        public TriangleTest()
        {
            circle = new Triangle();
        }

        [TestMethod]
        public void GetAreaTest()
        {
            double correct = 0.43;
            double result = circle.GetArea(1, 1, 1);
            if (result != correct)
            {
                throw new Exception($"ќтвет: {result}. ѕравильный ответ: {correct}");
            }
        }

        [TestMethod]
        public void IsRectangularTest()
        {
            #region ѕ–яћќ”√ќЋ№Ќџ…
            bool correct = true;
            bool result = circle.IsRectangular(4, 3, 5);
            if (result != correct)
            {
                throw new Exception($"ќтвет: {result}. ѕравильный ответ: {correct}");
            }
            #endregion

            #region Ќ≈ѕ–яћќ”√ќЋ№Ќџ…
            correct = false;
            result = circle.IsRectangular(1, 1, 1);
            if (result != correct)
            {
                throw new Exception($"ќтвет: {result}. ѕравильный ответ: {correct}");
            }
            #endregion
        }
    }
}

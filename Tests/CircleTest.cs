using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLibrary;
using System;

namespace Tests
{
    [TestClass]
    public class CircleTest
    {
        Circle circle;

        public CircleTest()
        {
            circle = new Circle();
        }

        double correct;
        double result;

        [TestMethod]
        public void GetAreaTest()
        {
            correct = 12.57;
            result = circle.GetArea(2);
            if (result != correct)
            {
                throw new Exception($"Ответ: {result}. Правильный ответ: {correct}");
            }
        }
    }
}

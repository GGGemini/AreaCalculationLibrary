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
                throw new Exception($"�����: {result}. ���������� �����: {correct}");
            }
        }

        [TestMethod]
        public void IsRectangularTest()
        {
            #region �������������
            bool correct = true;
            bool result = circle.IsRectangular(4, 3, 5);
            if (result != correct)
            {
                throw new Exception($"�����: {result}. ���������� �����: {correct}");
            }
            #endregion

            #region ���������������
            correct = false;
            result = circle.IsRectangular(1, 1, 1);
            if (result != correct)
            {
                throw new Exception($"�����: {result}. ���������� �����: {correct}");
            }
            #endregion
        }
    }
}

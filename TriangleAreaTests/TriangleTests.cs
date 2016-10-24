using System;
using TriangleArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleAreaTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetTriangleArea_WithValidSides_ReturnsArea()
        {
            double expected = 54;
            var triangle = new Triangle(9,12,15);
            double actual = triangle.GetTriangleArea();
            Assert.AreEqual<double>(expected, actual);
        }

        [TestMethod]
        public void GetTriangleAreaStatic_WithValidSides_ReturnsArea()
        {
            double expected = 54;
            double actual = Triangle.GetTriangleArea(9, 12, 15);
            Assert.AreEqual<double>(expected, actual);
        }

        [TestMethod]
        public void GetTriangleAreaStatic_WithValidArrayOfSides_ReturnsArea()
        {
            double expected = 54;
            double actual = Triangle.GetTriangleArea(new double[] { 9, 12, 15 });
            Assert.AreEqual<double>(expected, actual);
        }
    }
}

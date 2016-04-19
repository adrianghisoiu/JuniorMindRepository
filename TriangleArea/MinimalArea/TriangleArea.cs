using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleArea
{
    [TestClass]
    public class TriangleArea
    {
        [TestMethod]
        public void FirstTestMinimalArea()
        {
            double area = CalculateMinimalArea(0.000000, 0.000000,0.000000, 0.000000, 0.000000, 0.000000);
            Assert.AreEqual(0.000000, area);
        }
        [TestMethod]
        public void SecondTestMinimalArea()
        {
            double area = CalculateMinimalArea(0.000000, 0.000000, 1.000000, 0.000000, 1.000000, 0.000000);
            Assert.AreEqual(2.000000, area);
        }

        double CalculateMinimalArea(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            double A = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
            double B = Math.Sqrt(Math.Pow((xC - xA), 2) + Math.Pow((yA - yC), 2));
            double C = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));
            double perimeter = A + B + C;
            double calculArea = Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
            return calculArea;
        }
    }
}

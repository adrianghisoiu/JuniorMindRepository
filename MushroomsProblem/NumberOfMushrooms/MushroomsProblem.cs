using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberOfMushrooms
{
    [TestClass]
    public class MushroomsProblem
    {
        [TestMethod]
        public void TestForDoubleRedMushrooms()
        {
            double redMushrooms = CalculateNumberOfRedMushrooms(9, 2, 3, 6);
            Assert.AreEqual(6, redMushrooms);
        }
        [TestMethod]
        public void TestForAnotherRedMushrooms()
        {
            double redMushrooms = CalculateNumberOfRedMushrooms(50, 7, 6.25, 43.75);
            Assert.AreEqual(43.75, redMushrooms);
        }


        double CalculateNumberOfRedMushrooms(double totalMushrooms, double x, double white, double red)
        {
            totalMushrooms = red + white;
            white = totalMushrooms / (x + 1);
            return red = x * white;
        }
    }
}

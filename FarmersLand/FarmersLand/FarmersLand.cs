using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand
{
    [TestClass]
    public class FarmersLand
    {
        [TestMethod]
        public void TestForInitialDimension()
        {
            Assert.AreEqual(770, CalculateInitialDimension(770000));
        }

        double CalculateInitialDimension(double finalDimension)
        {
            double a = 1;
            double b = 230;
            double initialDimension = 0;

            double equation = a * a + 230 * b - finalDimension;
            double sqrtpart = (b * b) - (4 * a * (-1)*finalDimension);
            if (sqrtpart > 0)
            {
                initialDimension = (-b + Math.Sqrt(sqrtpart)) / (a * 2);
                // x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a); we don't need this because gives us a negative value
            }
           
            return initialDimension;
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rent
{
    [TestClass]
    public class Rent
    {
        [TestMethod]
        public void RentPenalityForShortPeriod()
        {
            Assert.AreEqual(2, CalculateRentPenality(100, 1));
        }

        double CalculateRentPenality(int rent, int days)
        {
            return 0.02 * rent * days;
        }
    }
}

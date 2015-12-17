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

        [TestMethod]
        public void RentPenalityForMediumPeriod()
        {
            Assert.AreEqual(55, CalculateRentPenality(100, 11));
        }

        double CalculateRentPenality(int rent, int days)
        {
            double RentForShorPeriod = 0.02 * rent * days;
            if (days >= 1 && days <= 10)
            {
                return RentForShorPeriod;
            }
            else
            return 0.05 * rent * days;

        }
    }
}

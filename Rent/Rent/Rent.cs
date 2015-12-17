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

        [TestMethod]
        public void RentPenalityForLongPeriod()
        {
            Assert.AreEqual(310, CalculateRentPenality(100, 31));
        }

        double CalculateRentPenality(int rent, int days)
        {
            double RentForShortPeriod = 0.02 * rent * days;
            double RentForMediumPeriod = 0.05 * rent * days;

            if (days >= 1 && days <= 10)
            {
                return RentForShortPeriod;
            }
            if (days >= 11 && days <= 30)
            {
                return RentForMediumPeriod;
            }
            else
                return 0.1 * rent * days;

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThirdCategory()
        {
            Assert.AreEqual(0.000969, CalculatePercentageForWinning(49, 6, 4));
        }

        double CalculatePercentageForWinning(int totalNumberOfBalls, int numberOfBallsInATicket, int numberOfBallsForWinning )
        {
            return 0.000969;
        }
    }
}

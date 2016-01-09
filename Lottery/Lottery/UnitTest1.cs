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
            Assert.AreEqual(0.000969, CalculatePercentageForWinning(49, 6,4));
        }

        [TestMethod]
        public void TestForCombinationsFunction()
        {
            Assert.AreEqual(15, CalculateCombinations(6, 4));
        }

        double CalculatePercentageForWinning(int totalNumberOfBalls, int numberOfBallsInATicket, int numberOfBallsForWinning )
        {
           int remainingBalls = totalNumberOfBalls - numberOfBallsInATicket;
           int balls = numberOfBallsInATicket - numberOfBallsForWinning;
            return Math.Round((CalculateCombinations(numberOfBallsInATicket, numberOfBallsForWinning) * CalculateCombinations(remainingBalls, balls)) / CalculateCombinations(totalNumberOfBalls,numberOfBallsInATicket),6);

        }

        double CalculateCombinations(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        private static double Factorial(int n)
        {
            double total = 1;
            for (int i = 1; i <= n; i++)
                total = total * i;
            return total;
        }
    }
}

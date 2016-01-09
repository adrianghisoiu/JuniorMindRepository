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

        [TestMethod]
        public void TestForCombinationsFunction()
        {
            Assert.AreEqual(15, CalculateCombinations(6, 4));
        }

        [TestMethod]
        public void SecondCategory()
        {
            Assert.AreEqual(0.0000184, CalculatePercentageForWinning(49, 6, 5));
        }

        [TestMethod]
        public void FirstCategory()
        {
            Assert.AreEqual(0.0000000715, CalculatePercentageForWinning(49, 6, 6));
        }

        double CalculatePercentageForWinning(int totalNumberOfBalls, int numberOfBallsInATicket, int numberOfBallsForWinning)
        {
            int remainingBalls = totalNumberOfBalls - numberOfBallsInATicket;
            int balls = numberOfBallsInATicket - numberOfBallsForWinning;
            double calculateThePercentage = (CalculateCombinations(numberOfBallsInATicket, numberOfBallsForWinning) * CalculateCombinations(remainingBalls, balls)) / CalculateCombinations(totalNumberOfBalls, numberOfBallsInATicket);
            if (numberOfBallsForWinning == 4)
                return Math.Round(calculateThePercentage, 6);
            if (numberOfBallsForWinning == 5)
                return Math.Round(calculateThePercentage, 7);
            else
                return Math.Round(calculateThePercentage, 10);
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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void ThirdCategory()
        {
            Assert.AreEqual(0.000969, CalculatePercentageForWinning(49, 6, 4), 1e-6);
        }

        [TestMethod]
        public void TestForCombinationsFunction()
        {
            Assert.AreEqual(15, CalculateCombinations(6, 4));
        }

        [TestMethod]
        public void SecondCategory()
        {
            Assert.AreEqual(0.0000184, CalculatePercentageForWinning(49, 6, 5), 1e-7);
        }

        [TestMethod]
        public void FirstCategory()
        {
            Assert.AreEqual(0.0000000715, CalculatePercentageForWinning(49, 6, 6), 1e-10);
        }

        [TestMethod]
        public void FirstCategoryFiveFromForty()
        {
            Assert.AreEqual(0.0000015, CalculatePercentageForWinning(40, 5, 5), 1e-7);
        }

        double CalculatePercentageForWinning(int totalNumberOfBalls, int numberOfBallsInATicket, int numberOfBallsForWinning)
        {
            int remainingBalls = totalNumberOfBalls - numberOfBallsInATicket;
            int balls = numberOfBallsInATicket - numberOfBallsForWinning;
            return (CalculateCombinations(numberOfBallsInATicket, numberOfBallsForWinning) * CalculateCombinations(remainingBalls, balls)) / CalculateCombinations(totalNumberOfBalls, numberOfBallsInATicket);

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

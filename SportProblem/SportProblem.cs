using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportProblem
{
    [TestClass]
    public class SportProblem
    {
        [TestMethod]
        public void RepetitionForThreeRounds()
        {
            int total = CalculateNumberOfRepetetitions(9, 3);
            Assert.AreEqual(9, total);           
        }

        int CalculateNumberOfRepetetitions(int totalRepetitions, int rounds)
        {
            totalRepetitions = rounds * rounds;
            return totalRepetitions;
        }
    }
}

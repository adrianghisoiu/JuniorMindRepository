using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoatProblem
{
    [TestClass]
    public class GoatProblem
    {
        [TestMethod]
        public void FirstTest()
        {
            int hayKilograms = CalculateKilogramsEatedByGoat(2, 2, 2, 4, 2);
            Assert.AreEqual(1, hayKilograms);
        }

        int CalculateKilogramsEatedByGoat(int xDays, int yGoats, int zKilograms, int wDays, int qGoats)
        {
            return (xDays * qGoats * zKilograms) / (yGoats * wDays);
            
        }
    }
}

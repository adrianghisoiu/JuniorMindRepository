using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void FirstNumber()
        {
            Assert.AreEqual(192, CalculateCubeOfANumber(1));
        }

        [TestMethod]
        public void TestForAKNumber()
        {
            Assert.AreEqual(1692, CalculateCubeOfANumber(7));
        }

        int CalculateCubeOfANumber(int k)
        {
            int[] myNumber = new int[k+1];
            myNumber[0] = 192;

            for (int i = 1; i < k; i++)
                myNumber[i] = myNumber[i - 1] + 250;
            return myNumber[k - 1];
        }
    }
}

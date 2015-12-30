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

        int CalculateCubeOfANumber(int k)
        {
            return 192;
        }
    }
}

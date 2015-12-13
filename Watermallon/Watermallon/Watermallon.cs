using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermallon
{
    [TestClass]
    public class Watermallon
    {
        [TestMethod]
        public void TestForParity()
        {
            Assert.AreEqual("Da", CalculateParityForWatermallon(2));
        }

        string CalculateParityForWatermallon(int myNumberParity)
        {
            bool testParity = myNumberParity % 2 == 0;
            if (testParity)
                return "Da";
            return Convert.ToString(myNumberParity);
        }
    }
}

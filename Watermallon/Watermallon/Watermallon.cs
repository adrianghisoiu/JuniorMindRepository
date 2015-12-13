using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermallon
{
    [TestClass]
    public class Watermallon
    {
        [TestMethod]
        public void TestForParityWithResponseYes()
        {
            Assert.AreEqual("Da", CalculateParityForWatermallon(4));
        }
        [TestMethod]
        public void TestForParityWithResponseNo()
        {
            Assert.AreEqual("Nu", CalculateParityForWatermallon(3));
        }

        string CalculateParityForWatermallon(int myNumberParity)
        {
            bool testParity = myNumberParity % 2 == 0;
            if (testParity)
                return "Da";
            else
                return "Nu";
            return Convert.ToString(myNumberParity);
        }
    }
}

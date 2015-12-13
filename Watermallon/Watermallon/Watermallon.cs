using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermallon
{
    [TestClass]
    public class Watermallon
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Da", CalculateParityForWatermallon(2));
        }

        string CalculateParityForWatermallon(int myNumberParity)
        {
            if (myNumberParity % 2 == 0)
                return "Da";
            return Convert.ToString(myNumberParity);
        }
    }
}

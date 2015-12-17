using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbers
    {
        [TestMethod]
        public void ConversionOfOne()
        {
            Assert.AreEqual("I", ConvertInRomanNumbers(1));
        }

        string ConvertInRomanNumbers(int myNumber)
        {
            return "I";
        }
    }
}

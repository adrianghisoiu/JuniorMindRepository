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

        [TestMethod]
        public void ConversionOfTwentySix()
        {
            Assert.AreEqual("XXVI", ConvertInRomanNumbers(26));
        }

        string ConvertInRomanNumbers(int myNumber)
        {
            string[] romanNumbersOne = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] romanNumberTwo = new string[] { "", "X", "XX", "XXX", "LX", "L", "LX", "LXX", "LXXX", "XC" };

            return romanNumberTwo[myNumber / 10] + romanNumbersOne[myNumber % 10];
        }
    }
}

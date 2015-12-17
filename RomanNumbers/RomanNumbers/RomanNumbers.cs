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

        [TestMethod]
        public void ConversionOfSixHundredSixtySix()
        {
            Assert.AreEqual("DCLXVI", ConvertInRomanNumbers(666));
        }

        string ConvertInRomanNumbers(int myNumber)
        {
            string[] romanNumbersOne = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] romanNumberTwo = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] romanNumberThree = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                return romanNumberThree[myNumber/100] + romanNumberTwo[myNumber % 100 / 10] + romanNumbersOne[myNumber % 10];
        }
    }
}

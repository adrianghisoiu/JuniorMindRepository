using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void FirstLetter()
        {
            Assert.AreEqual("A", ConvertToObtainMyChar(1));
        }

        [TestMethod]
        public void TwentyEightLetter()
        {
            Assert.AreEqual("AB", ConvertToObtainMyChar(28));
        }

        string ConvertToObtainMyChar(int myNumber)
        {
            string myChar = string.Empty;
            int modulo;
            while (myNumber > 0)
            {
                myNumber--;
                modulo = myNumber % 26;
                myChar = (char)('A' + modulo) + myChar;
                myNumber /= 26;
            }
            return myChar;
        }
    }
}

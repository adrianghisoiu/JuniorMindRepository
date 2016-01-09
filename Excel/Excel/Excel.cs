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

        string ConvertToObtainMyChar(int myNumber)
        {
            char myChar;
            myNumber--;
            myChar = (char)('A' + myNumber);
            return Char.ToString(myChar);
        }
    }
}

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
            return Char.ToString('A');
        }
    }
}

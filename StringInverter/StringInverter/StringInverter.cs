using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringInverter
{
    [TestClass]
    public class StringInverter
    {
        [TestMethod]
        public void TestForStringInverter()
        {
            Assert.AreEqual("ieH", Reverse("Hei"));
        }

        string Reverse(string myString)
        {
            return (myString.Length > 0) ? myString[myString.Length - 1] + Reverse(myString.Substring(0, myString.Length - 1)) : myString;
        }
    }
}

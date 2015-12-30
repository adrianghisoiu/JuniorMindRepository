using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForPanagram()
        {
            Assert.AreEqual("Yes", SeeIfItsAPanagrams("abcdefghijklmnopqrstuvwxyz"));
        }

        string SeeIfItsAPanagrams(string myString)
        {
            return "Yes";
        }
    }
}

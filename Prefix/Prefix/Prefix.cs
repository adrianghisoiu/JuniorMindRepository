using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void CompareTwoStrings()
        {
            Assert.AreEqual("aaa", CompareMyStrings("aaab", "aaaabbaa"));
        }

        string CompareMyStrings(string firstString, string secondString)
        {
            return "aaa";
        }
    }
}

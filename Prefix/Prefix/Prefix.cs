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
        [TestMethod]
        public void CompareTwoString()
        {
            Assert.AreEqual("baBa", CompareMyStrings("baBa", "baBaNOVAC"));
        }

        string CompareMyStrings(string firstString, string secondString)
        {
            int myPrefixLength = 0;

            for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
            {
                if (firstString[i] != secondString[i])
                    break;
                myPrefixLength++;
            }
            return firstString.Substring(0, myPrefixLength);
        }
    }
}

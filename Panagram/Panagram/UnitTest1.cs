﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text.RegularExpressions;

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

        [TestMethod]
        public void TestForUniqueCharacters()
        {
            Assert.AreEqual("The quickbrownfxjmpsvtlazydg", GetUniqueCharacters("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void TestForASentence()
        {
            Assert.AreEqual("Yes", SeeIfItsAPanagrams("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void TestForNotAPanagram()
        {
            Assert.AreEqual("No", SeeIfItsAPanagrams("the quick brown fox"));
        }

        [TestMethod]
        public void TestForEliminateNonAlpha()
        {
            Assert.AreEqual("abc", EliminateNonAlpha("a + b + c"));
        }

        string SeeIfItsAPanagrams(string myString)
        {
            return GetUniqueCharacters(myString).Length >= 26 ? "Yes" : "No";
        }

        string EliminateNonAlpha(string myString)
        {
                Regex reg = new Regex("[^a-zA-Z']");
                string myNewString = reg.Replace(myString, string.Empty);
            return myNewString;
        }

        string GetUniqueCharacters(string myString)
        {
            var myNewString = String.Join("", myString.Distinct());
            return myNewString;
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Panagram
{
    [TestClass]
    public class Panagram
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

        [TestMethod]
        public void TestForNoPanagramSpecialCharacters()
        {
            Assert.AreEqual("No", SeeIfItsAPanagrams("abcdefghijklmnopqrstuvwxy "));
        }

        string SeeIfItsAPanagrams(string myString)
        {
            return GetUniqueCharacters(EliminateNonAlpha(myString.ToLower())).Length == 26 ? "Yes" : "No";
        }

        string EliminateNonAlpha(string myString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < myString.Length; i++)
            {
                if (char.IsLetterOrDigit(myString[i]))
                {
                    sb.Append(myString[i]);
                }
            }
            return sb.ToString();
        }

        string GetUniqueCharacters(string myString)
        {
            var myNewString = String.Join("", myString.Distinct());
            return myNewString;
        }
    }
}

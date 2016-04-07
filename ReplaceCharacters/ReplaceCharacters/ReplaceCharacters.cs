using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceCharacters
{
    [TestClass]
    public class ReplaceCharacters
    {
        [TestMethod]
        public void CharToReplace()
        {
            Assert.AreEqual("ahhchh", ReplaceChar("abcb", 'b', "hh"));
        }

        string ReplaceChar(string firstString, char toReplace, string secondString)
        {
            if (firstString.Length > 0)
                if (firstString[firstString.Length - 1] == toReplace)
                    return ReplaceChar(firstString.Substring(0, firstString.Length - 1), toReplace, secondString) + secondString;
            else
            return ReplaceChar(firstString.Substring(0, firstString.Length - 1), toReplace, secondString) + firstString[firstString.Length - 1];

            return firstString;
        }
    }
}

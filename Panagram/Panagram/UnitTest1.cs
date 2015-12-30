using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            Assert.AreEqual("Yes", SeeIfItsAPanagrams("the quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void TestFoNotAPanagram()
        {
            Assert.AreEqual("No", SeeIfItsAPanagrams("the quick brown fox"));
        }

        string SeeIfItsAPanagrams(string myString)
        {
            string myNewString = GetUniqueCharacters(myString);
            int contor = 1;
            bool check = true;

            for (int i = 0; i < (myNewString.Length - 1); i++)
            {
                if (myNewString[i] != Convert.ToChar(" "))
                {
                    for (int j = i + 1; j < myNewString.Length; j++)
                        if (myNewString[i] == myNewString[j])
                            check = false;
                    if (check == true)
                        contor++;
                }
            }
            if (contor == 26)
                return "Yes";
            else
                return "No";
        }

        string GetUniqueCharacters(string myString)
        {
            var myNewString = String.Join("", myString.Distinct());
            return myNewString;
        }
    }
}

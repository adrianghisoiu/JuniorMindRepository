using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void TestForFindingAChar()
        {
            Assert.AreEqual(3, CountMatches("abbaacc", 'a'));
        }

        [TestMethod]
        public void TestForGetUniqueCharacters()
        {
            Assert.AreEqual("abc", GetUniqueCharacters("abbaacc"));
        }

        [TestMethod]
        public void TestForNumberOfAnagrams()
        {
            Assert.AreEqual(210, CountMyNumberOfAnagrams("abbaacc"));
        }

        int CountMatches(string myString, char toFind)
        {
            int contorChar=0;
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] == toFind)
                    contorChar++;
            return contorChar;
        }

        string GetUniqueCharacters(string myString)
        {
            var myNewString = String.Join("", myString.Distinct());
            return myNewString;
        }

        int CountMyNumberOfAnagrams(string myString)
        {
            int permutationOfLetters = Factorial(myString.Length);
            int numberOfAnagrams = permutationOfLetters;
            string myNewString = GetUniqueCharacters(myString);
            for (int i = 0; i < myNewString.Length; i++)
                 numberOfAnagrams /= Factorial(CountMatches(myString, myNewString[i]));
            return numberOfAnagrams;
        }

        private static int Factorial(int n)
        {
            int total = 1;
            for (int i = 1; i <= n; i++)
                total = total * i;
            return total;
        }
    }
}
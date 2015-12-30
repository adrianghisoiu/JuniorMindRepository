using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        int CountMatches(string myString, char toFind)
        {
            int contorChar=0;
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] == toFind)
                    contorChar++;
            return contorChar;
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
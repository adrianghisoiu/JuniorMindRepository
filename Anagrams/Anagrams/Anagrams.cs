using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void TestForLowerCase()
        {
            Assert.AreEqual(6, CalculateNumberOfAnagrams("abab"));
        }

        [TestMethod]
        public void TestForUpperCase()
        {
            Assert.AreEqual(2, CalculateNumberOfAnagrams("AB"));
        }

        int CalculateNumberOfAnagrams(string myString)
        {
            int total = Factorial(myString.Length);
            string[] myStringArray = ConvertMyString(myString);
            myStringArray[myString.Length] = null;

            for (int i = 0; i < myString.Length; i++)
            {
                int contor = 1;
                for (int j = i + 1; j <= myString.Length; j++)
                    if (myStringArray[i] != null && myStringArray[i] == myStringArray[j])
                    {
                        contor++;
                        myStringArray[j] = null;
                    }
                total = total / Factorial(contor);
            }

            return total;
        }

        private static string[] ConvertMyString(string myString)
        {
            string[] myStringArray = new string[myString.Length + 1];
            for (int i = 0; i < myString.Length; i++)
            {
                myStringArray[i] = myString[i].ToString();
            }
            return myStringArray;
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
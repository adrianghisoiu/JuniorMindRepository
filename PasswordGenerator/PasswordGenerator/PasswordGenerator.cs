using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordGenerator
{
    [TestClass]
    public class PasswordGenerator
    {
        [TestMethod]
        public void TestForSmallLetters()
        {
            Assert.AreEqual(6, SeeHowManySmallLetters(SmallLettersGenerator(6)));
        }

        [TestMethod]
        public void TestToSeeHowManySmallLetters()
        {
            Assert.AreEqual(3, SeeHowManySmallLetters("abc"));
        }

        string SmallLettersGenerator(int number=6)
        {
            Random rand = new Random();
            char c = (char)0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = (char)('a' + rand.Next(0, 26));
                myString += c.ToString();
            }
            return myString;
        }

        int SeeHowManySmallLetters(string myString)
        {
            int contor = 0;
            for (int i = 0; i < myString.Length; i++)
                if(myString[i] >= 'a' && myString[i] <= 'z')
                    contor++;
 
            return contor;
        }
    }
}

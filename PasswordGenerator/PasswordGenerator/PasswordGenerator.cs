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
            Assert.AreEqual(6, CountLowerCaseLetters(GeneratePassword(6)));
        }

        [TestMethod]
        public void TestToSeeHowManySmallLetters()
        {
            Assert.AreEqual(3, CountLowerCaseLetters("abc"));
        }

        private static string GeneratePassword(int number)
        {
            Random rand = new Random();
            string myString = CharactersGenerator(number, rand);
            return myString;
        }

        private static string CharactersGenerator(int number, Random rand)
        {
            char c = (char)0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = (char)('a' + rand.Next(0, 26));
                myString += c.ToString();
            }

            return myString;
        }

        int CountLowerCaseLetters(string myString)
        {
            return CountCharacters(myString);
        }

        private static int CountCharacters(string myString)
        {
            int contor = 0;
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] >= 'a' && myString[i] <= 'z')
                    contor++;

            return contor;
        }
    }
}

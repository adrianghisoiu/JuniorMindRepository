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
        public void TestForCountLowerCaseLetters()
        {
            Assert.AreEqual(3, CountLowerCaseLetters("abc"));
        }

        [TestMethod]
        public void TestForUpperCaseLetters()
        {
            Assert.AreEqual(3, CountUpperCaseLetters(GeneratePassword(6, 3)));
        }

        private static string GeneratePassword(int passwordLength, int upperNumber=0)
        {
            Random rand = new Random();
            string myString = CharactersGenerator(passwordLength, rand, 'a', 'z')
                + CharactersGenerator(upperNumber, rand, 'A', 'Z');
            return myString;
        }

        private static string CharactersGenerator(int number, Random rand, char first, char second)
        {
            char c = (char)0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = (char)(rand.Next(first, second));
                myString += c.ToString();
            }

            return myString;
        }

        int CountLowerCaseLetters(string myString)
        {
            return CountCharacters(myString, 'a', 'z');
        }

        int CountUpperCaseLetters(string myString)
        {
            return CountCharacters(myString, 'A', 'Z');
        }

        private static int CountCharacters(string myString, char first, char second)
        {
            int contor = 0;
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] >= first && myString[i] <= second)
                    contor++;

            return contor;
        }
    }
}

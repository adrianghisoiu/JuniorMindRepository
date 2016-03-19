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
            var actual = GeneratePassword(6, 3);
            Assert.AreEqual(3, CountUpperCaseLetters(actual));
            Assert.AreEqual(6, actual.Length);
        }

        [TestMethod]
        public void TestForNumbers()
        {
            var actual = GeneratePassword(6, 2, 2);
            Assert.AreEqual(2, CountNumbers(actual));
            Assert.AreEqual(6, actual.Length);
        }

        [TestMethod]
        public void TestForSymbols()
        {
            var actual = GeneratePassword(10, 2, 2, 4);
            Assert.AreEqual(4, CountSymbols(actual));
            Assert.AreEqual(2, CountNumbers(actual));
            Assert.AreEqual(2, CountUpperCaseLetters(actual));
            Assert.AreEqual(2, CountLowerCaseLetters(actual));
        }

        [TestMethod]
        public void TestForExcludeSimilarCharacters()
        {
            /*var actual = GeneratePassword(10, 2, 2, 4);
            char[] similarCharacters = { 'l', '1', 'I', 'o', '0', 'O' };
            Assert.AreEqual*/
        }

        private static string GeneratePassword(int passwordLength, int upperNumber=0, int number = 0, int numberSymbols = 0)
        {
            Random rand = new Random();
            char[] symbols = { '!', '"', '#', '$', '%', '&', '\'',  '(' , ')', '*' , '+', ',', '-', '.', '/', ':', ';',
            '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'};
            string myString = CharactersGenerator(passwordLength - upperNumber - number - numberSymbols, rand, 'a', 'z')
                + CharactersGenerator(upperNumber, rand, 'A', 'Z')
                + CharactersGenerator(number, rand, '0', '9')
                + GenerateSymbols(numberSymbols, rand, 0, symbols.Length, symbols);
            
            return myString;
        }

        static string GenerateSymbols(int number, Random rand,int first, int second, char[] symbols )
        {
            int c = 0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = rand.Next(first, second);
                myString += symbols[c].ToString();
            }
            return myString;
        }
        private static string CharactersGenerator(int number, Random rand, char first, char second)
        {
            char c = (char)0;
            char[] similarCharacters = { 'l', '1', 'I', 'o', '0', 'O' };
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = (char)(rand.Next(first, second + 1));
                while(Array.IndexOf(similarCharacters, c) >= 0)
                {
                    c = (char)(rand.Next(first, second + 1));
                }
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

        int CountNumbers(string myString)
        {
            return CountCharacters(myString, '0', '9');
        }

        int CountSymbols(string myString)
        {
            char[] symbols = { '!', '"', '#', '$', '%', '&', '\'',  '(' , ')', '*' , '+', ',', '-', '.', '/', ':', ';',
            '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'};

            return CountSymbols(myString, 0, symbols.Length, symbols);
        }

        private static int CountCharacters(string myString, char first, char second)
        {
            int contor = 0;
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] >= first && myString[i] <= second)
                    contor++;

            return contor;
        }

        int CountSymbols(string myString, int first, int second, char[] symbols)
        {
            int contor = 0;
            for (int i = 0; i < myString.Length; i++)
              if(Array.IndexOf(symbols,myString[i])>=0)
                    contor++;

            return contor;
        }
    }
}

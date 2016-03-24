using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PasswordGenerator
{
    [TestClass]
    public class PasswordGenerator
    {
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
            char[] excluded = { 'b' };
            Assert.AreEqual("aaa", CharactersGenerator(3, new Random(), 'a', 'b', excluded));
        }

        [TestMethod]
        public void TestForExcludeAmbiguousCharacters()
        {
            char[] symbols = { 'a', 'b' };
            char[] excluded = { 'a' };
            Assert.AreEqual("bbb", GenerateSymbols(3, new Random(), symbols, excluded));
        }
        
        private static string GeneratePassword(int passwordLength, int upperNumber=0, int number = 0, int numberSymbols = 0)
        {
            Random rand = new Random();
            char[] symbols = { '!', '"', '#', '$', '%', '&', '\'',  '(' , ')', '*' , '+', ',', '-', '.', '/', ':', ';',
            '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'};
            char[] ambiguousCharacters = { '{', '}', '[', ']', '(', ')', '/', '\\', '\'', '"', '~', ',', ';', '.', '<', '>' };
            char[] similarCharacters = { 'l', '1', 'I', 'o', '0', 'O' };

            string myString = CharactersGenerator(passwordLength - upperNumber - number - numberSymbols, rand, 'a', 'z', similarCharacters)
                + CharactersGenerator(upperNumber, rand, 'A', 'Z', similarCharacters)
                + CharactersGenerator(number, rand, '0', '9', similarCharacters)
                + GenerateSymbols(numberSymbols, rand, symbols, ambiguousCharacters);

            return ShufflePassword(myString);
        }

        static string GenerateSymbols(int number, Random rand, char[] symbols, char[] excludedSymbols )
        {
            int c = 0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = rand.Next(0, symbols.Length);
                while (Array.IndexOf(excludedSymbols, symbols[c]) >= 0)
                {
                    c = rand.Next(0, symbols.Length);
                }
                myString += symbols[c].ToString();
            }
            return myString;
        }

        private static string CharactersGenerator(int number, Random rand, char first, char second, char[] excludedCharacters)
        {
            char c = (char)0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = (char)(rand.Next(first, second + 1));
                while(Array.IndexOf(excludedCharacters, c) >= 0)
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

        static string ShufflePassword(string myString)
        {
            Random rand = new Random();
            char[] finalPassword = myString.ToCharArray();           
            int contor = finalPassword.Length;
            while (contor > 1)
            {
                contor--;
                int k = rand.Next(contor + 1);
                var value = finalPassword[k];
                finalPassword[k] = finalPassword[contor];
                finalPassword[contor] = value;
            }
            return new string(finalPassword);
        }
    }
}

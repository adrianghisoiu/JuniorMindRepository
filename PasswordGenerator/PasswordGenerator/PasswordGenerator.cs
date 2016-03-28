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
            string excluded = "b";
            Assert.AreEqual("aaa", CharactersGenerator(3, new Random(), 'a', 'b', excluded));
        }

        [TestMethod]
        public void TestForExcludeAmbiguousCharacters()
        {
            string symbols = "ab";
            string excluded = "a";
            Assert.AreEqual("bbb", GenerateSymbols(3, new Random(), symbols, excluded));
        }
        
        struct Options
        {
            bool ambiguousCharacters;
            bool similarCharacters;

            public Options(bool ambiguousCharacters, bool similarCharacters)
            {
                this.ambiguousCharacters = ambiguousCharacters;
                this.similarCharacters = similarCharacters;
            }
        }

        private static string GeneratePassword(int passwordLength, int upperNumber=0, int number = 0, int numberSymbols = 0, bool similarCharacters = true, bool ambiguousCharacters = true)
        {
            Random rand = new Random();
            string symbols = "!\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~}";
            string ambiguous = null, similar = null;
            
            if(similarCharacters == true)
                similar = "l, 1, I, o, 0, O";
            string myString = CharactersGenerator(passwordLength - upperNumber - number - numberSymbols, rand, 'a', 'z', similar)
                + CharactersGenerator(upperNumber, rand, 'A', 'Z', similar)
                + CharactersGenerator(number, rand, '0', '9', similar);

            if (ambiguousCharacters == true)
                ambiguous = "{}[]()/\'\"~,;.<>";
            myString += GenerateSymbols(numberSymbols, rand, symbols, ambiguous);

            return ShufflePassword(myString);
        }

        static string GenerateSymbols(int number, Random rand, string symbols, string excludedSymbols )
        {
            int c = 0;
            string myString = null;
            char[] exclude = excludedSymbols.ToCharArray(0, excludedSymbols.Length);
            for (int i = 0; i < number; i++)
            {
                c = rand.Next(0, symbols.Length);
                while (Array.IndexOf(exclude, symbols[c]) >= 0)
                {
                    c = rand.Next(0, symbols.Length);
                }
                myString += symbols[c].ToString();
            }
            return myString;
        }

        private static string CharactersGenerator(int number, Random rand, char first, char second, string excludedCharacters)
        {
            char c = (char)0;
            string myString = null;
            char[] exclude = excludedCharacters.ToCharArray(0, excludedCharacters.Length);
            for (int i = 0; i < number; i++)
            {
                c = (char)(rand.Next(first, second + 1));
                while(Array.IndexOf(exclude, c) >= 0)
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

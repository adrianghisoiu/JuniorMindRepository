using System;
using Xunit;

namespace WordsSorting
{
    public class WordTest
    {
        [Theory]
        [InlineData("a", "a", 0)]
        [InlineData("a", "b", -1)]
        [InlineData("b", "a", 1)]
        public void CompareWords(string a, string b, int expected)
        {
            var wordFirst = new Word(a, 1);
            var wordSecond = new Word(b, 1);
            Assert.Equal(expected, wordFirst.CompareTo(wordSecond));
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(1, 2, -1)]
        [InlineData(2, 1, 1)]
        public void CompareByCount(int a, int b, int expected)
        {
            var wordFirst = new Word("a", a);
            var wordSecond = new Word("b", b);
            Assert.Equal(expected, wordFirst.CompareToByCount(wordSecond));
        }
    }
}

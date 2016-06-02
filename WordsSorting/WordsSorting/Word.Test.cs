using System;
using Xunit;

namespace WordsSorting
{
    public class WordTest
    {
        [Theory]
        [InlineDataAttribute("a", "a", 0)]
        public void Word(string a, string b, int expected)
        {
            var wordFirst = new Word("a", 1);
            var wordSecond = new Word("a", 1);
            Assert.Equal(expected, wordFirst.CompareTo(wordSecond));
        }
    }
}

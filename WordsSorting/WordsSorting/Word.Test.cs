using System;
using Xunit;

namespace WordsSorting
{
    public class WordTest
    {
        [Theory]
        [InlineData("a", "a", 0)]
        [InlineData("a", "b", -1)]
        public void CompareWord(string a, string b, int expected)
        {
            var wordFirst = new Word(a, 1);
            var wordSecond = new Word(b, 1);
            Assert.Equal(expected, a.CompareTo(b));
        }
    }
}

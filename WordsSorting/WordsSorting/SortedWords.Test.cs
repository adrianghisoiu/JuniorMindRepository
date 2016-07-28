using System;
using Xunit;


namespace WordsSorting
{
    public class SortingWordsTest
    {
        [Fact]
        public void SortByCount()
        {
            Words words = new Words { "b", "b", "a" };
            var sortedWords = new SortedWords(words, (a, b) => a.CompareToByCount(b));
            Assert.Equal(new[] { new Word("b", 2), new Word("a", 1) }, sortedWords);
        }

        [Fact]
        public void SortByWord()
        {
            Words words = new Words { "b", "b", "a" };
            var sortedWords = new SortedWords(words);
            Assert.Equal(new[] { new Word("a", 1), new Word( "b", 2) }, sortedWords);
        }
    }
}

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
            var sortedWords = new SortedWords(words, "count");
            Assert.Equal(new[] { new Word("b", 2), new Word("a", 1)}, words);
        }

        [Fact]
        public void SortByWord()
        {
            Words words = new Words { "b", "b", "a" };
            var sortedWords = new SortedWords(words, "word");
            Assert.Equal(new[] { new Word("a", 1), new Word( "b", 2) }, sortedWords);
        }
    }
}

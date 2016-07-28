using System;
using Xunit;


namespace WordsSorting
{
    public class SortingWordsTest
    {
        [Fact]
        public void SortByCount()
        {
            var words = new SortedWords(new Words { "b", "b", "a" }, (a, b) => a.CompareToByCount(b));
            Assert.Equal(new[] { new Word("b", 2), new Word("a", 1) }, words);
        }

        [Fact]
        public void SortByWord()
        {
            var words = new SortedWords(new Words { "b", "b", "a" });
            Assert.Equal(new[] { new Word("a", 1), new Word( "b", 2) }, words);
        }
    }
}

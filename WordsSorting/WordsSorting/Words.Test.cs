using System;
using System.Linq;
using Xunit;

namespace WordsSorting
{
    public class WordsTest
    {
        [Fact]
        public void AddWord()
        {
            Words words = new Words { "a" };
            Assert.Equal(new[] { new Word("a", 1) }, words);
        }

        [Fact]
        public void AddTwoWords()
        {
            Words words = new Words { "b", "a", "a" };
            var sortedWords = new SortedWords(words, "count");
            Assert.Equal(new[] { new Word("a", 2), new Word("b", 1)}, sortedWords);
        }

        [Fact]
        public void AddMoreWords()
        {
            Words words = new Words() { "a", "b", "c", "c", "b", "b" };
            var sortedWords = new SortedWords(words, "count");
            Assert.Equal(new[] { new Word("b", 3), new Word("c", 2), new Word("a", 1) }, sortedWords);
        }
    }
}

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
            var words = new SortedWords(new Words { "b", "a", "a" }, (a, b) => a.CompareToByCount(b));
            Assert.Equal(new[] { new Word("a", 2), new Word("b", 1)}, words);
        }

        [Fact]
        public void AddMoreWords()
        {
            var words = new SortedWords(new Words { "a", "b", "c", "c", "b", "b" }, (a, b) => a.CompareToByCount(b));
            Assert.Equal(new[] { new Word("b", 3), new Word("c", 2), new Word("a", 1) }, words);
        }
    }
}

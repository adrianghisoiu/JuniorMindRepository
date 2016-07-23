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
            var expected = "a";
            Words words = new Words();
            words.Add(expected);
            Assert.Equal(new[] { new Word(expected, 1) }, words);
        }

        [Fact]
        public void AddTwoWords()
        {
            var expected = "a a b";
            Words words = new Words();
            string[] final = expected.Split(' ');
            foreach (string w in final)
            {
                words.Add(w);
            }
            Assert.Equal(new[] { new Word("a", 2), new Word("b", 1)}, words);
        }

        [Fact]
        public void AddMoreWords()
        {
            var expected = "a b c c b b";
            Words words = new Words();
            string[] final = expected.Split(' ');
            foreach (string w in final)
            {
                words.Add(w);
            }
            Assert.Equal(new[] { new Word("b", 3), new Word("c", 2), new Word("a", 1) }, words);
        }
    }
}

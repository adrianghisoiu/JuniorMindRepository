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
    }
}

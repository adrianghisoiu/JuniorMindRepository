using System;
using Xunit;

namespace WordsSorting
{
    public class WordTest
    {
        [Fact]
        public void Word()
        {
            var final = new Word("Andrew", 1);
            var word = "Andrew1" ;
            Assert.Equal(final.WordToReturn(), word);
        }
    }
}

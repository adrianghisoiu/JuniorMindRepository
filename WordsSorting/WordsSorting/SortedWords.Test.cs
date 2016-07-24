using System;
using Xunit;


namespace WordsSorting
{
    public class SortingWordsTest
    {
        [Fact]
        public void SortByCount()
        {
            var expected = "b b a";
            Words words = new Words();
            string[] final = expected.Split(' ');
            foreach (string w in final)
            {
                words.Add(w, "count");
            }
            Assert.Equal(new[] { new Word("b", 2), new Word("a", 1)}, words);
        }
    }
}

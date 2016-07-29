using System;
using Xunit;

namespace List
{
    public class ListTest
    {
        [Fact]
        public void TestForCount()
        {
            var firstList = new List<string>();
            firstList.Add("b");
            firstList.Add("c");
            Assert.Equal(2, firstList.Count);
        }

        [Fact]
        public void TestForClear()
        {
            var firstList = new List<string>();
            firstList.Add("a");
            firstList.Add("b");
            firstList.Clear();
            Assert.Equal(0, firstList.Count);
        }

        [Fact]
        public void TestForAddAndContains()
        {
            var firstList = new List<string>();
            firstList.Add("a");
            Assert.True(firstList.Contains("a"));
        }

        [Fact]
        public void TestForCopyTo()
        {
            var firstList = new List<string> { "a", "b" };
            var moveHere = new string[] { "c", "d", "e" };
            firstList.CopyTo(moveHere, 1);
            Assert.Equal(new string[] { "c", "a", "b" }, moveHere);
        }
    }
}

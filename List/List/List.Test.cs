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
            var firstList = new string[] { "a", "b" };
            var moveHere = new string[] { "c", "d", "e" };
            firstList.CopyTo(moveHere, 1);
            Assert.Equal(new string[] { "c", "a", "b" }, moveHere);
        }

        [Fact]
        public void TestForIndexOf()
        {
            var firstList = new List<string> { "a", "b" };
            Assert.Equal(1, firstList.IndexOf("b"));
        }

        [Fact]
        public void TestForRemoveAt()
        {
            var firstList = new List<string> { "a", "b" };
            firstList.RemoveAt(1);
            Assert.Equal(new[] { "a" }, firstList);
        }

        [Fact]
        public void TestForRemove()
        {
            var firstList = new List<string> { "a", "b" };
            Assert.True(firstList.Remove("a"));
            Assert.False(firstList.Remove("c"));
        }

        [Fact] 
        public void TestForInsert()
        {
            var firstList = new List<string> { "a", "b" };
            firstList.Insert(1, "c");
            Assert.Equal(new[] { "a", "c", "b" }, firstList);
        }

        [Fact]
        public void TestForArgumentOutOfRange()
        {
            var firstList = new List<string> { "a", "b" };
            Assert.Throws<ArgumentOutOfRangeException>(() => firstList.RemoveAt(100));
        }

        [Fact]
        public void TestForCopyToExceptions()
        {
            var first = new string[] { "a", "b" };
            var second = (string[])null;
            var third = new string[] { "a", "c" };

           //ArgumentNullException is not working
            Assert.Throws<ArgumentNullException>(() => third.CopyTo(second, 0)); 
            Assert.Throws<ArgumentOutOfRangeException>(() => first.CopyTo(third, -1));
            Assert.Throws<ArgumentException>(() => first.CopyTo(third, 3));
        }

        [Fact]
        public void TestForInserException()
        {
            var firstList = new List<string> { "a", "b" };
            Assert.Throws<ArgumentOutOfRangeException>(() => firstList.Insert(5, "c"));
        }
    }
}

using System;
using Xunit;

namespace LinkedList
{
    public class LinkedListTest
    {
        [Fact]
        public void TestForAddFirst()
        {
            var linkedList = new LinkedList<string> { };
            linkedList.AddFirstItem("a");
            Assert.Equal(new[] { "a" }, linkedList);
        }
    }
}

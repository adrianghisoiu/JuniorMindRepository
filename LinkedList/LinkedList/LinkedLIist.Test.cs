using System;
using Xunit;

namespace LinkedList
{
    public class LinkedListTest
    {
        [Fact]
        public void TestForAddFirst()
        {
            var linkedList = new LinkedList<string> {"a"};
            linkedList.AddLast("c");
            Assert.Equal(new[] { "a", "c" }, linkedList);
        }

        [Fact]
        public void TestForAddLast()
        {
            var linkedList = new LinkedList<string> { };
            linkedList.AddLast("a");
            linkedList.AddLast("b");
            linkedList.AddLast("c");
            Assert.Equal(new[] { "a", "b","c" }, linkedList);        
        }
    }
}

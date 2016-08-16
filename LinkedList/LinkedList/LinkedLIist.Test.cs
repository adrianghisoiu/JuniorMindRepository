using System;
using Xunit;

namespace LinkedList
{
    public class LinkedListTest
    {
        [Fact]
        public void TestForAdd()
        {
            var linkedList = new LinkedList<string> {"a"};
            linkedList.Add("c");
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

        [Fact]
        public void TestForAddFirst()
        {
            var linkedList = new LinkedList<string> { "a" };
            linkedList.AddFirst("b");
            Assert.Equal(new[] { "b", "a" }, linkedList);
        }

        [Fact]
        public void TestForRemoveLast()
        {
            var linkedtList = new LinkedList<string> { "a", "b"};
            linkedtList.RemoveLast();
            Assert.Equal(new[] { "a" }, linkedtList);
        }
    }
}

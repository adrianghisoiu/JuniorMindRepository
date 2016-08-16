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

        [Fact]
        public void TestForRemoveFirst()
        {
            var linkedtList = new LinkedList<string> { "a", "b" };
            linkedtList.RemoveFirst();
            Assert.Equal(new[] { "b" }, linkedtList);
        }

        [Fact]
        public void TestForRemoveAt()
        {
            Node<string> toRemove = new Node<string>("b");
            Node<string> toRemove2 = new Node<string>("d");
            var linkedList = new LinkedList<string> { "a", "b", "c" };
            linkedList.RemoveNode(toRemove);
            Assert.Equal(new[] { "a", "c" }, linkedList);
        }

        [Fact]
        public void TestForFind()
        {
            Node<string> toFind = new Node<string>("b");
            var linkedList = new LinkedList<string> { "a", "b", "c" };
            Assert.True(linkedList.Find(toFind));
        }
    }
}

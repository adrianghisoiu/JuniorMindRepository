using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void TestForCount()
        {
            var firstList = new List<string>();
            firstList.Add("b");
            firstList.Add("c");
            Assert.AreEqual(2, firstList.Count);
        }

        [TestMethod]
        public void TestForClear()
        {
            var firstList = new List<string>();
            firstList.Add("a");
            firstList.Add("b");
            firstList.Clear();
            Assert.AreEqual(0, firstList.Count);
        }
    }
}

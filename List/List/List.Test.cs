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
    }
}

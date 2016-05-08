using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsSorting
{
    [TestClass]
    public class TestsClass
    {
        [TestMethod]
        public void TestForOccurance()
        {
            var occurance = new Words(new string[] { "One", "two", "three", "three", "four" });
            Assert.AreEqual(2, occurance.GetOcurrances("three"));
        }
    }
}

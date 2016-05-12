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

        [TestMethod]
        public void TestForSort()
        {
            var inputString = new string[] { "One", "two", "three", "three", "four" };
            var test = new SortingWords();
            var sortedWords = new string[] { "three", "One", "two", "four" };
            CollectionAssert.AreEqual(sortedWords, test.InsertionSort(inputString));
        }
    }
}

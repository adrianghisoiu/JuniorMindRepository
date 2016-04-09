using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalsTriangle
{
    [TestClass]
    public class PascalsTriangle
    {
        [TestMethod]
        public void CalculatePascalTest()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, CalculatePascal(1));
        }

        int[] CalculatePascal(int line)
        {
            return new int[] { 1 };
        }
    }
}

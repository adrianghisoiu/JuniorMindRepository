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
            CollectionAssert.AreEqual(new int[] { 1, 1 }, CalculatePascal(2));
        }

        int[] CalculatePascal(int line)
        {
            int[] row = new int[line];
            row[0] = 1;
            row[line - 1] = 1;
            return row;
        }
    }
}

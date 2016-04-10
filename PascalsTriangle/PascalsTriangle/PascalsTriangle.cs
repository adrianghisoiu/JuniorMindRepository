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
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, CalculatePascal(3));
        }

        int[] CalculatePascal(int line)
        {
            int[] final = new int[line];
            int[] row = new int[line];
            if (line == 1)
            {
                return new int[] { 1 };
            }

            row[0] = 1;
            row[line - 1] = 1;
            final = CalculatePascal(line - 1);
            CalculatePascal(line, final, row);
            return row;
        }

        private static void CalculatePascal(int line, int[] final, int[] row)
        {
            for (int j = 1; j < line - 1; j++)
                row[j] = final[j - 1] + final[j];
        }
    }
}

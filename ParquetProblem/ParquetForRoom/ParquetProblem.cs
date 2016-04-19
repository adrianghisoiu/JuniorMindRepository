using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParquetProblem
{
    [TestClass]
    public class ParquetProblem
    {
        [TestMethod]
        public void TestForRandomParquet()
        {
            float total = CalculateNumberOfParquet(3, 3, 2, 1);
            Assert.AreEqual(12.65, total, 1e-2);
        }
        [TestMethod]
        public void SecondTestForRandomParquet()
        {
            float total = CalculateNumberOfParquet(4, 4, 2, 1);
            Assert.AreEqual(18.4, total, 1e-1);
        }
        float CalculateNumberOfParquet(float n, float m, float a, float b)
        {
            float roomParquet = (n * m) / (a * b);
            if ((n * m) % (a * b) != 0)
                roomParquet += (n * m) % (a * b);
            float error = roomParquet * 15 / 100;
            float parquetWeNeed = roomParquet + error;
            return parquetWeNeed * (a * b);
        }
    }
}

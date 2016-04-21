using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Test
    {
        BasicCalculator instance = new BasicCalculator();

        [TestMethod]
        public void Sum()
        {
            var calculate = "+ 1 1";
            int param = 0;
            Assert.AreEqual(2, instance.Calculate(calculate, ref param));
        }

        [TestMethod]
        public void Substraction()
        {
            var calculate = "- 1 1";
            int param = 0;
            Assert.AreEqual(0, instance.Calculate(calculate, ref param));
        }

        [TestMethod]
        public void Multiplication()
        {
            var calculate = "* 2 2";
            int param = 0;
            Assert.AreEqual(4, instance.Calculate(calculate, ref param));
        }

        [TestMethod]
        public void Division()
        {
            var calculate = "/ 4 2";
            int param = 0;
            Assert.AreEqual(2, instance.Calculate(calculate, ref param));
        }

        [TestMethod]
        public void Operations()
        {
            var calculate = "+ / * + 56 45 46 3 - 1 0.25";
            int param = 0;
            Assert.AreEqual(1549.41, instance.Calculate(calculate, ref param), 1e-2);
        }
    }
}

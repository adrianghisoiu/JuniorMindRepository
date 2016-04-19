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
    }

    public class BasicCalculator
    {
        public double Calculate(string firstString, ref int param)
        {
            string[] elements = firstString.Split(' ');
            double result;
            string first = elements[param++];

            if (double.TryParse(first, out result))
            {
                return result;
            }

            return BasicOperations(firstString, ref param, first);
        }

        private double BasicOperations(string firstString, ref int param, string first)
        {
            if (first == "+")
                return Calculate(firstString, ref param) + Calculate(firstString, ref param);
            if (first == "-")
                return Calculate(firstString, ref param) - Calculate(firstString, ref param);
            if (first == "*")
                return Calculate(firstString, ref param) * Calculate(firstString, ref param);
            if (first == "/")
                return Calculate(firstString, ref param) / Calculate(firstString, ref param);
            else
                return 0;
        }
    }
}

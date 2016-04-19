using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Test
    {
        BasicCalculator instance = new BasicCalculator();
        [TestMethod]
        public void FirstTest()
        {
            var calculate = "+ 1 1";
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

            if(double.TryParse(first, out result))
            { 
                return result;
            }

            if (first == "+")
                return Calculate(firstString, ref param) + Calculate(firstString, ref param);
            else
                return 0;
        }
    }
}

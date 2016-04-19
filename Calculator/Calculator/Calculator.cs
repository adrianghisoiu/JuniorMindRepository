using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculate = "+ 1 1";
            var instance = new BasicCalculator();
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

            if(double.TryParse(elements[param++], out result))
            { 
                return result;
            }

            return Calculate(firstString, ref param) + Calculate(firstString, ref param);
        }
    }
}

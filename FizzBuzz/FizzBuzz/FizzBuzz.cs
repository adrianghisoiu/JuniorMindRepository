using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Fizz", CalculateFizzBuzz(3));
        }

        String CalculateFizzBuzz(int myNumber)
        {
            if (myNumber % 3 == 0)
                return "Fizz";
            return Convert.ToString(myNumber);
        }
    }
}

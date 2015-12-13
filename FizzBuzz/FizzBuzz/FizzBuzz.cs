using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestFizz()
        {
            Assert.AreEqual("Fizz", CalculateFizzBuzz(3));
        }
        [TestMethod]
        public void TestBuzz()
        {
            Assert.AreEqual("Buzz", CalculateFizzBuzz(5));
        }

        String CalculateFizzBuzz(int myNumber)
        {
            if (myNumber % 3 == 0)
                return "Fizz";
            if (myNumber % 5 == 0)
                return "Buzz";
            return Convert.ToString(myNumber);
        }
    }
}

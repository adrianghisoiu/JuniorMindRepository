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

        [TestMethod]
        public void TestFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", CalculateFizzBuzz(30));
        }

        String CalculateFizzBuzz(int myNumber)
        {
            if (myNumber % 5 == 0 && myNumber % 3 == 0)
                return "FizzBuzz";
            if (myNumber % 3 == 0)
                return "Fizz";
            if (myNumber % 5 == 0)
                return "Buzz";
            if ((myNumber % 5 == 0) && (myNumber % 3 == 0))
                return "FizzBuzz";
            return Convert.ToString(myNumber);
        }
    }
}

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
            bool divisionWithFive = myNumber % 5 == 0;
            bool divisionWithThree = myNumber % 3 == 0;
            if (divisionWithFive && divisionWithThree)
                return "FizzBuzz";
            if (divisionWithThree)
                return "Fizz";
            if (divisionWithFive)
                return "Buzz";
        
            return Convert.ToString(myNumber);
        }
    }
}

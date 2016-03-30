using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void FindFirstFibonacciNumber()
        {
            Assert.AreEqual(1, FindTheFibonacciNumber(1));
        }

        [TestMethod]
        public void FindTheSeventhFibonacciNumber()
        {
            Assert.AreEqual(13, FindTheFibonacciNumber(7));
        }

    
        int FindTheFibonacciNumber(int number)
        {
            return (number < 2) ? number : FindTheFibonacciNumber(number - 1) + FindTheFibonacciNumber(number - 2);
        }
    }
}

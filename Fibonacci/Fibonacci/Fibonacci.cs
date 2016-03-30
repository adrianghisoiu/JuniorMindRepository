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

    
        int FindTheFibonacciNumber(int number)
        {
            return number;
        }
    }
}

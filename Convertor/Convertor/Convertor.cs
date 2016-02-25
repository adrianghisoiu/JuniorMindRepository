using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Convertor
{
    [TestClass]
    public class Convertor
    {
        [TestMethod]
        public void TestGetElement()
        {
            Assert.AreEqual(1, GetElement(new byte[] { 3, 2, 1}, 0));
        }

        byte GetElement(byte[] myByteArray, int position)
        {
            return myByteArray[myByteArray.Length - 1 - position];
        }
    }
}

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
            Assert.AreEqual(0, GetElement(new byte[] { 3, 2, 1 }, 4));
        }

        [TestMethod]
        public void TestForConvert()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0}, ConvertToBinary(2));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ConvertToBinary(7));
        }

        [TestMethod]
        public void TestOperatorNot()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, Not(new byte[] { 1, 0 }));
        }

        [TestMethod]
        public void TestOperatorAnd()
        {
            CollectionAssert.AreEqual(ConvertToBinary(3 & 6), And(ConvertToBinary(3), ConvertToBinary(6)));
            CollectionAssert.AreEqual(ConvertToBinary(3 & 96), And(ConvertToBinary(3), ConvertToBinary(96)));
        }

        [TestMethod]
        public void TestForCounter()
        {
            Assert.AreEqual(3, CountZero(new byte[] { 0, 0, 0, 1, 2 }));
            Assert.AreEqual(1, CountZero(new byte[] { 0, 1, 0, 0, 2 }));
        }

        byte GetElement(byte[] myByteArray, int position)
        {
            return (byte)(position < myByteArray.Length ? myByteArray[myByteArray.Length - 1 - position] : 0);
        }

        byte[] ConvertToBinary(int numberToConvert)
        {
            int i = 0;
            byte[] convertedNumber = new byte[0];
            while(numberToConvert > 0)
            {
                Array.Resize(ref convertedNumber, i+1);
                convertedNumber[i++] = (byte)(numberToConvert % 2);
                numberToConvert = numberToConvert / 2;
            }
            Array.Reverse(convertedNumber);
            return convertedNumber;
        }

        byte[] Not(byte[] numberNot)
        {
            for (int i = 0; i < numberNot.Length; i++)
                numberNot[i] = (numberNot[i] == 0) ? (byte)(1) : (byte)(0);
            return numberNot;
        }

        byte[] And(byte[] firstNumber, byte[] secondNumber)
        {
            byte[] numberAnd = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < numberAnd.Length; i++)
                numberAnd[i] = (byte)(GetElement(firstNumber, i) * GetElement(secondNumber,i));

            Array.Resize(ref numberAnd, numberAnd.Length - CountZero(numberAnd));
            Array.Reverse(numberAnd);
            
            return numberAnd;
        }

        int CountZero(byte[] number)
        {
            int count = 0;
            while (count < number.Length && number[count] == 0)
                count++;
            return count;
        }
    }
}

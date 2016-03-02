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
            Assert.AreEqual(1, GetElement(new byte[] { 3, 2, 1 }, 0));
            Assert.AreEqual(0, GetElement(new byte[] { 3, 2, 1 }, 4));
        }

        [TestMethod]
        public void TestForConvert()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConvertToBinary(2));
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

        [TestMethod]
        public void TestOperatorOr()
        {
            CollectionAssert.AreEqual(ConvertToBinary(3 | 6), Or(ConvertToBinary(3), ConvertToBinary(6)));
        }

        [TestMethod]
        public void TestOpertorXor()
        {
            CollectionAssert.AreEqual(ConvertToBinary(3 ^ 6), Xor(ConvertToBinary(3), ConvertToBinary(6)));
        }

        [TestMethod]
        public void TestForRightHandShift()
        {
            CollectionAssert.AreEqual(ConvertToBinary(2 >> 1), RightHandShift(new byte[] { 1, 0 }, 1));
        }

        [TestMethod]
        public void TestForLeftHandShift()
        {
            CollectionAssert.AreEqual(ConvertToBinary(2 << 1), LeftHandShift(new byte[] { 1, 0 }, 1));
        }

        [TestMethod]
        public void TestForLessThan()
        {
            CollectionAssert.AreEqual(ConvertToBinary(5), LessThan(ConvertToBinary(5), ConvertToBinary(7)));
        }

        byte GetElement(byte[] myByteArray, int position)
        {
            return (byte)(position < myByteArray.Length ? myByteArray[myByteArray.Length - 1 - position] : 0);
        }

        byte[] ConvertToBinary(int numberToConvert)
        {
            int i = 0;
            byte[] convertedNumber = new byte[0];
            while (numberToConvert > 0)
            {
                Array.Resize(ref convertedNumber, i + 1);
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
            return ExecuteLogicalOperation(firstNumber, secondNumber, "and");
        }

        private byte[] ExecuteLogicalOperation(byte[] firstNumber, byte[] secondNumber, string operation)
        {
            byte[] number = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < number.Length; i++)
            {
                var a = GetElement(firstNumber, i);
                var b = GetElement(secondNumber, i);
               number[i] = ExecuteLogicalOperation(a, b, operation);
            }

            Array.Resize(ref number, number.Length - CountZero(number));
            Array.Reverse(number);

            return number;
        }

        private byte ExecuteLogicalOperation(byte firstNumber, byte secondNumber, string operation)
        {
            switch (operation)
            {
                case "and":
                    return AndLogic(firstNumber, secondNumber);
                case "or":
                    return OrLogic(firstNumber, secondNumber);
            }
              return XorLogic(firstNumber, secondNumber);
        }

        private byte AndLogic(byte first, byte second)
        {
            return (byte)(first * second);
        }

        int CountZero(byte[] number)
        {
            int count = 0;
            while (count < number.Length && number[count] == 0)
                count++;
            return count;
        }

        byte[] Or(byte[] firstNumber, byte[] secondNumber)
        {
            return ExecuteLogicalOperation(firstNumber, secondNumber, "or");
        }

        private byte OrLogic(byte first, byte second)
        {
            return first == 1 || second == 1 ? (byte)1 : (byte)0;
        }

        byte[] Xor(byte[] firstNumber, byte[] secondNumber)
        {
            return ExecuteLogicalOperation(firstNumber, secondNumber, "xor");
        }

        private byte XorLogic(byte first, byte second)
        {
            return first == second ? (byte)0 : (byte)1;
        }

        byte[] RightHandShift(byte[] number, int position)
        {
            Array.Resize(ref number, position);

            return number;
        }

        byte[] LeftHandShift(byte[] number, int position)
        {
            Array.Resize(ref number, number.Length + position);

            return number;
        }

        byte[] LessThan(byte[] firstNumer, byte[] secondNumber)
        {
            byte[] numberLess = new byte[0];
            for (int i = Math.Max(firstNumer.Length, secondNumber.Length); i > 0; i--)
                if (GetElement(firstNumer, i) < GetElement(secondNumber, i))
                    numberLess = firstNumer;
                else
                    numberLess = secondNumber;
            return numberLess;
        }
    }
}

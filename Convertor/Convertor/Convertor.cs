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
            Assert.AreEqual(1, CountZero(new byte[] { 1, 0 }));
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
            Assert.AreEqual(true, LessThan(ConvertToBinary(5), ConvertToBinary(7)));
            Assert.AreEqual(false, LessThan(ConvertToBinary(7), ConvertToBinary(5)));
            Assert.AreEqual(false, LessThan(ConvertToBinary(5), ConvertToBinary(5)));
            Assert.AreEqual(false, LessThan(ConvertToBinary(8), ConvertToBinary(2)));
        }

        [TestMethod]
        public void TestForCalculateSum()
        {
            CollectionAssert.AreEqual(ConvertToBinary(3), CalculateSum(ConvertToBinary(1), ConvertToBinary(2)));
        }

        [TestMethod]
        public void TestForCalculateSubstraction()
        {
            CollectionAssert.AreEqual(ConvertToBinary(1), CalculateSubstraction(ConvertToBinary(2), ConvertToBinary(1)));
            CollectionAssert.AreEqual(ConvertToBinary(7), CalculateSubstraction(ConvertToBinary(11), ConvertToBinary(4)));
        }
  
        [TestMethod]
        public void TestForCalculateMultiplication()
        {
            CollectionAssert.AreEqual(ConvertToBinary(6), CalculateMultiplication(ConvertToBinary(3), ConvertToBinary(2)));
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
               number[i] = ExecuteLogicalOperation(GetElement(firstNumber, i), GetElement(secondNumber, i), operation);
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
            int i = number.Length - 1;
            while (i > 0 && number[i] == 0)
            {
                count++;
                i--;
            }
                
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

        bool LessThan(byte[] firstNumber, byte[] secondNumber)
        {
            bool numberLess = false;
            for (int i = Math.Max(firstNumber.Length, secondNumber.Length); i > 0; i--)
                if ((GetElement(firstNumber, i) != GetElement(secondNumber, i)))
                {
                    numberLess = (GetElement(firstNumber, i) < GetElement(secondNumber, i));
                    break;
                }
            return numberLess;
        }

        byte[] CalculateSum(byte[] firstNumber, byte[] secondNumber)
        {
            int reminder = 0;
            int total = 0;
            byte[] finalNumber = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            int i = 0;

            while (i < finalNumber.Length)
            {
                total = GetElement(firstNumber, i) + GetElement(secondNumber, i) + reminder;
                finalNumber[i] = (byte)(total % 2);
                reminder = total / 2;
                i++;
            }

            if( reminder == 1)
            {
                Array.Resize(ref finalNumber, finalNumber.Length + 1);
                i = finalNumber.Length - 1;
                finalNumber[i] = 1;
            }

            Array.Reverse(finalNumber);
            return finalNumber;
        }

        byte[] CalculateSubstraction(byte[] firstNumber, byte[] secondNumber)
        {
            int reminder = 0;
            int total = 0;
            int i = 0;
            byte[] finalNumber = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];

            while(i < finalNumber.Length)
            {
                total = 2 + GetElement(firstNumber, i) - GetElement(secondNumber, i) - reminder;
                finalNumber[i] = (byte)(total % 2);
                reminder = (total < 2) ? 1 : 0;
                i++;
            }

            Array.Resize(ref finalNumber, finalNumber.Length - CountZero(finalNumber));
            Array.Reverse(finalNumber);

            return finalNumber;
        }

       byte[] CalculateMultiplication(byte[] firstNumber, byte[] secondNumber)
        {
            byte[] result = { 0 };
            for (byte[] i = { 0 }; LessThan(i, secondNumber); i = CalculateSum(i, new byte[] { 1 }))
                result = CalculateSum(result, firstNumber);

            return result;
        }
    }
}

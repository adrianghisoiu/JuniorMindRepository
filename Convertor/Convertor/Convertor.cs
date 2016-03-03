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
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConverToBinary(2));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ConverToBinary(7));
        }

        [TestMethod]
        public void TestOperatorNot()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, Not(new byte[] { 1, 0 }));
        }

        [TestMethod]
        public void TestOperatorAnd()
        {
            CollectionAssert.AreEqual(ConverToBinary(3 & 6), And(ConverToBinary(3), ConverToBinary(6)));
            CollectionAssert.AreEqual(ConverToBinary(3 & 96), And(ConverToBinary(3), ConverToBinary(96)));
        }

        [TestMethod]
        public void TestForCounter()
        {
            Assert.AreEqual(1, CountZero(new byte[] { 1, 0 }));
        }

        [TestMethod]
        public void TestOperatorOr()
        {
            CollectionAssert.AreEqual(ConverToBinary(3 | 6), Or(ConverToBinary(3), ConverToBinary(6)));
        }

        [TestMethod]
        public void TestOpertorXor()
        {
            CollectionAssert.AreEqual(ConverToBinary(3 ^ 6), Xor(ConverToBinary(3), ConverToBinary(6)));
        }

        [TestMethod]
        public void TestForRightHandShift()
        {
            CollectionAssert.AreEqual(ConverToBinary(2 >> 1), RightHandShift(new byte[] { 1, 0 }, 1));
        }

        [TestMethod]
        public void TestForLeftHandShift()
        {
            CollectionAssert.AreEqual(ConverToBinary(2 << 1), LeftHandShift(new byte[] { 1, 0 }, 1));
        }

        [TestMethod]
        public void TestForLessThan()
        {
            Assert.AreEqual(true, LessThan(ConverToBinary(5), ConverToBinary(7)));
            Assert.AreEqual(false, LessThan(ConverToBinary(7), ConverToBinary(5)));
            Assert.AreEqual(false, LessThan(ConverToBinary(5), ConverToBinary(5)));
            Assert.AreEqual(false, LessThan(ConverToBinary(8), ConverToBinary(2)));
        }

        [TestMethod]
        public void TestForCalculateSum()
        {
            CollectionAssert.AreEqual(ConverToBinary(3), CalculateSum(ConverToBinary(1), ConverToBinary(2)));
        }

        [TestMethod]
        public void TestForCalculateSubstraction()
        {
            CollectionAssert.AreEqual(ConverToBinary(1), CalculateSubstraction(ConverToBinary(2), ConverToBinary(1)));
            CollectionAssert.AreEqual(ConverToBinary(7), CalculateSubstraction(ConverToBinary(11), ConverToBinary(4)));
        }
  
        [TestMethod]
        public void TestForCalculateMultiplication()
        {
            CollectionAssert.AreEqual(ConverToBinary(6), CalculateMultiplication(ConverToBinary(3), ConverToBinary(2)));
        }

        [TestMethod]
        public void TestForCalculateDivision()
        {
            CollectionAssert.AreEqual(ConverToBinary(2), CalculateDivision(ConverToBinary(6), ConverToBinary(3)));
        }

        [TestMethod]
        public void TestForGraterThan()
        {
            Assert.AreEqual(true, GraterThan(ConverToBinary(5), ConverToBinary(2)));
            Assert.AreEqual(false, GraterThan(ConverToBinary(5), ConverToBinary(7)));
        }

        [TestMethod]
        public void TestForEqual()
        {
            Assert.AreEqual(true, Equal(ConverToBinary(5), ConverToBinary(5)));
            Assert.AreEqual(false, Equal(ConverToBinary(3), ConverToBinary(5)));
        }

        [TestMethod]
        public void TestForNotEqual()
        {
            Assert.AreEqual(true, NotEqual(ConverToBinary(3), ConverToBinary(5)));
            Assert.AreEqual(false, NotEqual(ConverToBinary(3), ConverToBinary(3)));
        }

        [TestMethod]
        public void TestForConvertToAnyBase()
        {
            CollectionAssert.AreEqual(new byte[] { 10 }, ConvertToAnyBase(10, 16));
        }

        byte GetElement(byte[] myByteArray, int position)
        {
            return (byte)(position < myByteArray.Length ? myByteArray[myByteArray.Length - 1 - position] : 0);
        }

        byte[] ConverToBinary(int numberToConvert)
        {
            int i = 0;
            if (numberToConvert == 0)
                return new byte[] { 0 };
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
            for (int i = Math.Max(firstNumber.Length, secondNumber.Length) - 1; i >= 0; i--)
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

        byte[] CalculateDivision(byte[] firstNumber, byte[] secondNumber)
        {
            byte[] result = { 0 };
            int contor =  0 ;

            while (LessThan(new byte[] { 0 }, firstNumber))
            {
               firstNumber = CalculateSubstraction(firstNumber, secondNumber);
                contor++;
            }
            result = ConverToBinary(contor);

            return result;
        }

        bool GraterThan(byte[] firstNumber, byte[] secondNumber)
        {
            return (LessThan(firstNumber, secondNumber)) ? false : true;
        }

        bool Equal(byte[] firstNumber, byte[] secondNumber)
        {
            return (!(LessThan(firstNumber, secondNumber) || LessThan(secondNumber, firstNumber))) ? true : false;
        }

        bool NotEqual(byte[] firstNumber, byte[] secondNumber)
        {
            return (!Equal(firstNumber, secondNumber)) ? true : false;
        }

        byte[] ConvertToAnyBase(int numberToConvert, int numberBase)
        {
            int i = 0;
            byte[] convertedNumber = new byte[0];
            while (numberToConvert > 0)
            {
                Array.Resize(ref convertedNumber, i + 1);
                convertedNumber[i++] = (byte)(numberToConvert % numberBase);
                numberToConvert = numberToConvert / numberBase;
            }
            Array.Reverse(convertedNumber);
            return convertedNumber;
        }
    }
}

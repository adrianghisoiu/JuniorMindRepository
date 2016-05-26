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
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConvertToAnyBase(2));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ConvertToAnyBase(7));
        }

        [TestMethod]
        public void TestOperatorNot()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, Not(new byte[] { 1, 0 }));
        }

        [TestMethod]
        public void TestOperatorAnd()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(3 & 6), And(ConvertToAnyBase(3), ConvertToAnyBase(6)));
            CollectionAssert.AreEqual(ConvertToAnyBase(3 & 96), And(ConvertToAnyBase(3), ConvertToAnyBase(96)));
        }

        [TestMethod]
        public void TestForCounter()
        {
            Assert.AreEqual(1, CountZero(new byte[] { 1, 0 }));
        }

        [TestMethod]
        public void TestOperatorOr()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(3 | 6), Or(ConvertToAnyBase(3), ConvertToAnyBase(6)));
        }

        [TestMethod]
        public void TestOpertorXor()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(3 ^ 6), Xor(ConvertToAnyBase(3), ConvertToAnyBase(6)));
        }

        [TestMethod]
        public void TestForRightHandShift()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(2 >> 1), RightHandShift(new byte[] { 1, 0 }, 1));
        }

        [TestMethod]
        public void TestForLeftHandShift()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(2 << 1), LeftHandShift(new byte[] { 1, 0 }, 1));
        }

        [TestMethod]
        public void TestForLessThan()
        {
            Assert.AreEqual(true, LessThan(ConvertToAnyBase(5), ConvertToAnyBase(7)));
            Assert.AreEqual(false, LessThan(ConvertToAnyBase(7), ConvertToAnyBase(5)));
            Assert.AreEqual(false, LessThan(ConvertToAnyBase(5), ConvertToAnyBase(5)));
            Assert.AreEqual(false, LessThan(ConvertToAnyBase(8), ConvertToAnyBase(2)));
            Assert.AreEqual(true, LessThan(ConvertToAnyBase(15, 16), ConvertToAnyBase(20, 16)));
        }

        [TestMethod]
        public void TestForCalculateSum()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(3), CalculateSum(ConvertToAnyBase(1), ConvertToAnyBase(2)));
            CollectionAssert.AreEqual(ConvertToAnyBase(10, 16), CalculateSum(ConvertToAnyBase(6, 16), ConvertToAnyBase(4,16), 16));
        }

        [TestMethod]
        public void TestForCalculateSubstraction()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(1), CalculateSubstraction(ConvertToAnyBase(2), ConvertToAnyBase(1)));
            CollectionAssert.AreEqual(ConvertToAnyBase(7), CalculateSubstraction(ConvertToAnyBase(11), ConvertToAnyBase(4)));
            CollectionAssert.AreEqual(ConvertToAnyBase(4, 16), CalculateSubstraction(ConvertToAnyBase(6, 16), ConvertToAnyBase(2, 16), 16));
        }

        [TestMethod]
        public void TestForCalculateMultiplication()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(6), CalculateMultiplication(ConvertToAnyBase(3), ConvertToAnyBase(2)));
            CollectionAssert.AreEqual(ConvertToAnyBase(9, 16), CalculateMultiplication(ConvertToAnyBase(3, 16), ConvertToAnyBase(3, 16), 16));
        }

        [TestMethod]
        public void TestForCalculateDivision()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(2), CalculateDivision(ConvertToAnyBase(6), ConvertToAnyBase(3)));
            CollectionAssert.AreEqual(ConvertToAnyBase(3, 16), CalculateDivision(ConvertToAnyBase(6, 16), ConvertToAnyBase(2, 16), 16));
        }

        [TestMethod]
        public void TestForGraterThan()
        {
            Assert.AreEqual(true, GraterThan(ConvertToAnyBase(5), ConvertToAnyBase(2)));
            Assert.AreEqual(false, GraterThan(ConvertToAnyBase(5), ConvertToAnyBase(7)));
            Assert.AreEqual(false, GraterThan(ConvertToAnyBase(5, 16), ConvertToAnyBase(7, 16)));
        }

        [TestMethod]
        public void TestForEqual()
        {
            Assert.AreEqual(true, Equal(ConvertToAnyBase(5), ConvertToAnyBase(5)));
            Assert.AreEqual(false, Equal(ConvertToAnyBase(3), ConvertToAnyBase(5)));
            Assert.AreEqual(false, Equal(ConvertToAnyBase(3, 16), ConvertToAnyBase(5, 16)));
            Assert.AreEqual(true, Equal(ConvertToAnyBase(8, 16), ConvertToAnyBase(8, 16)));
        }

        [TestMethod]
        public void TestForNotEqual()
        {
            Assert.AreEqual(true, NotEqual(ConvertToAnyBase(3), ConvertToAnyBase(5)));
            Assert.AreEqual(false, NotEqual(ConvertToAnyBase(3), ConvertToAnyBase(3)));
            Assert.AreEqual(false, NotEqual(ConvertToAnyBase(5, 16), ConvertToAnyBase(5, 16)));
            Assert.AreEqual(true, NotEqual(ConvertToAnyBase(18, 16), ConvertToAnyBase(7, 16)));
        }

        [TestMethod]
        public void TestForConvertToAnyBase()
        {
            CollectionAssert.AreEqual(new byte[] { 10 }, ConvertToAnyBase(10, 16));
        }

        /*[TestMethod]
        public void TestForFactorial()
        {
            CollectionAssert.AreEqual(ConvertToAnyBase(6), Factorial(ConvertToAnyBase(3)));
            byte[] a = ConvertToAnyBase(49);
            byte[] b = ConvertToAnyBase(48);
            CollectionAssert.AreEqual(a, Factorial(CalculateDivision(a, b)));
        }*/

        byte GetElement(byte[] myByteArray, int position)
        {
            return (byte)(position < myByteArray.Length ? myByteArray[myByteArray.Length - 1 - position] : 0);
        }

        byte[] ConvertToAnyBase(int numberToConvert, int baseToConvert = 2)
        {
            int i = 0;
            if (numberToConvert == 0)
                return new byte[] { 0 };
            byte[] convertedNumber = new byte[0];
            while (numberToConvert > 0)
            {
                Array.Resize(ref convertedNumber, i + 1);
                convertedNumber[i++] = (byte)(numberToConvert % baseToConvert);
                numberToConvert = numberToConvert / baseToConvert;
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

        delegate byte LogicalOperator(byte a, byte b);

        byte[] And(byte[] firstNumber, byte[] secondNumber)
        {
            return ExecuteLogicalOperation(firstNumber, secondNumber, AndLogic);
        }

        private byte[] ExecuteLogicalOperation(byte[] firstNumber, byte[] secondNumber, LogicalOperator operation)
        {
            byte[] number = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < number.Length; i++)
            {
               number[i] = operation(GetElement(firstNumber, i), GetElement(secondNumber, i));
            }

            Array.Resize(ref number, number.Length - CountZero(number));
            Array.Reverse(number);

            return number;
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
            return ExecuteLogicalOperation(firstNumber, secondNumber, OrLogic);
        }

        private byte OrLogic(byte first, byte second)
        {
            return first == 1 || second == 1 ? (byte)1 : (byte)0;
        }

        byte[] Xor(byte[] firstNumber, byte[] secondNumber)
        {
            return ExecuteLogicalOperation(firstNumber, secondNumber, XorLogic);
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

        byte[] CalculateSum(byte[] firstNumber, byte[] secondNumber, int baseNumber = 2)
        {
            int reminder = 0;
            int total = 0;
            byte[] finalNumber = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            int i = 0;

            while (i < finalNumber.Length)
            {
                total = GetElement(firstNumber, i) + GetElement(secondNumber, i) + reminder;
                finalNumber[i] = (byte)(total % baseNumber);
                reminder = total / baseNumber;
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

        byte[] CalculateSubstraction(byte[] firstNumber, byte[] secondNumber, int baseNumber = 2)
        {
            int reminder = 0;
            int total = 0;
            int i = 0;
            byte[] finalNumber = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];

            while(i < finalNumber.Length)
            {
                total = baseNumber + GetElement(firstNumber, i) - GetElement(secondNumber, i) - reminder;
                finalNumber[i] = (byte)(total % baseNumber);
                reminder = (total < baseNumber) ? 1 : 0;
                i++;
            }

            Array.Resize(ref finalNumber, finalNumber.Length - CountZero(finalNumber));
            Array.Reverse(finalNumber);

            return finalNumber;
        }

       byte[] CalculateMultiplication(byte[] firstNumber, byte[] secondNumber, int baseNumber = 2)
        {
            byte[] result = { 0 };
            for (byte[] i = { 0 }; LessThan(i, secondNumber); i = CalculateSum(i, new byte[] { 1 }, baseNumber))
                result = CalculateSum(result, firstNumber, baseNumber);

            return result;
        }

        byte[] CalculateDivision(byte[] firstNumber, byte[] secondNumber, int baseNumber = 2)
        {
            byte[] result = { 0 };
            int contor =  0 ;

            while (LessThan(new byte[] { 0 }, firstNumber))
            {
               firstNumber = CalculateSubstraction(firstNumber, secondNumber, baseNumber);
                contor++;
            }
            result = ConvertToAnyBase(contor, baseNumber);

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

        byte[] Factorial(byte[] number)
        {
            byte[] result = { 1 };
            for (byte[] i = { 1 }; LessThan(i, number); i = CalculateSum(i, new byte[] { 1 }))
                 result = CalculateMultiplication(result, i);

            return CalculateMultiplication(result, number);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoExtraction
{
    [TestClass]
    public class LottoExtraction
    {
        [TestMethod]
        public void TestIfNumbersAreSorted()
        {
            Assert.IsTrue(AreSorted(GenerateNumbers(6)));
        }

        [TestMethod]
        public void TestIfNumbersAreSorte2d()
        {
            Assert.IsTrue(AreSorted(GenerateNumbers(6)));
        }

        [TestMethod]
        public void TestIfNu3mbersAreSorted()
        {
            Assert.IsTrue(AreSorted(GenerateNumbers(6)));
        }

        [TestMethod]
        public void swsad()
        {
            Assert.IsTrue(AreSorted(GenerateNumbers(6)));
        }

        int[] GenerateNumbers(int totalNumber)
        {
            int[] generatedNumbers = new int[totalNumber];
            Random random = new Random();
            for (int i = 0; i < totalNumber; i++)
            {
                generatedNumbers[i] = random.Next(1, 49);
                generatedNumbers = InsertionSort(generatedNumbers);
            }

            return generatedNumbers;
        }

        int[] InsertionSort(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
                if (inputArray[i - 1] > inputArray[i])
                {
                    Swap(ref inputArray[i - 1], ref inputArray[i]);
                }
            return inputArray;
        }

        private static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        bool AreSorted(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] > inputArray[i])
                    return false;
            }
            return true;
        }
    }
}

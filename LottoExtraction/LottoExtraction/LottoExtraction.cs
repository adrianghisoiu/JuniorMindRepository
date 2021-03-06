﻿using System;
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

        int[] GenerateNumbers(int totalNumber)
        {
            int[] generatedNumbers = new int[totalNumber];
            Random random = new Random();
            for (int i = 0; i < totalNumber; i++)
            {
                generatedNumbers[i] = random.Next(1, 49);
                generatedNumbers = InsertionSort(generatedNumbers, generatedNumbers[i]);
            }

            return generatedNumbers;
        }

        int[] InsertionSort(int[] inputArray, int lastNumber)
        {
            for (int i = inputArray.Length - 1; i > 0; i--)
                if (lastNumber < inputArray[i-1])
                {
                    Swap(ref inputArray[i], ref inputArray[i - 1]);
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

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
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
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

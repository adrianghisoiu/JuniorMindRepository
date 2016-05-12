using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsSorting
{
    class SortingWords
    {
        public string[] InsertionSort(string[] inputString)
        {
            var word = new Words(inputString);
            for (int i = inputString.Length - 1; i > 0; i--)
                if ( word.GetOcurrances(inputString[i]) < word.GetOcurrances(inputString[i-1]))
                {
                    Swap(ref inputString[i], ref inputString[i - 1]);
                    {
                        for (int j = i - 1; j > 0; j--)
                        {
                            if (inputString[i] == inputString[j])
                            {
                                Swap(ref inputString[i], ref inputString[inputString.Length - 1]);
                                Array.Reverse(inputString);
                                Array.Resize(ref inputString, inputString.Length - 1);
                                Array.Reverse(inputString);
                            }
                        }
                    }
                }
            return inputString;
        }

        private static void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
    }
}

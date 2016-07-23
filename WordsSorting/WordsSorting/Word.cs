using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WordsSorting
{
    class Word
    {
        private string word;
        private int count;
        
        public Word(string word, int count)
        {
            this.word = word;
            this.count = count;
        }

        public int CompareTo(Word wordSecond)
        {
            return word.CompareTo(wordSecond.word);
        }

        public int CompareToByCount(Word wordSecond)
        {
            return count.CompareTo(wordSecond.count);
        }

        internal void IncrementWord()
        {
            count++;
        }

         public override string ToString()
        {
            return word + count;
        }

        public override bool Equals(object obj)
        {
            Word secondWord = obj as Word;
            if (secondWord == null)            
                return false;
           
            return (word == secondWord.word) && (count == secondWord.count);
        }

        public Word[] InsertionSort(Word[] inputString)
        {
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputString[j - 1].count < inputString[j].count)
                    {
                        Word temp = inputString[j - 1];
                        inputString[j - 1] = inputString[j];
                        inputString[j] = temp;
                    }
                }
            }
            return inputString;
        }
    }
}

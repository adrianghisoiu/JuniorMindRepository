using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WordsSorting
{
   class SortedWords : IEnumerable<Word>
    {
        private IEnumerable<Word> words;
        
        public SortedWords(IEnumerable<Word> words)
        {
            this.words = words;
        }

        public Word[] InsertionSort(Word[] words, string option)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (option.ToLower() == "count")
                        CompareByCount(words, j);                    
                    else if(option.ToLower() == "word")
                        CompareByWords(words, j);
                }
            }
            return words;
        }

        private static void CompareByWords(Word[] words, int j)
        {
            if (words[j - 1].CompareTo(words[j]) == 1)
            {
                Swap(words, j);
            }
        }

        private static void CompareByCount(Word[] words, int j)
        {
            if (words[j - 1].CompareToByCount(words[j]) == -1)
            {
                Swap(words, j);
            }
        }

        private static void Swap(Word[] words, int j)
        {
            Word temp = words[j - 1];
            words[j - 1] = words[j];
            words[j] = temp;
        }

        public IEnumerator<Word> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
   }
}

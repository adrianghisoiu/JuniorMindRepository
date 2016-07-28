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
        private Word[] words;
        private string option;

        public SortedWords(IEnumerable<Word> words, string option)
        {
            this.words = words.ToArray();
            this.option = option;
        }

        public void InsertionSort()
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (option.ToLower() == "count")
                        CompareByCount(j);                    
                    else if(option.ToLower() == "word")
                        CompareByWords(j);
                }
            }
        }

        private void CompareByWords(int j)
        {
            if (words[j - 1].CompareTo(words[j]) == 1)
            {
                Swap(j);
            }
        }

        private void CompareByCount(int j)
        {
            if (words[j - 1].CompareToByCount(words[j]) == -1)
            {
                Swap(j);
            }
        }

        private void Swap(int j)
        {
            Word temp = words[j - 1];
            words[j - 1] = words[j];
            words[j] = temp;
        }

        public IEnumerator<Word> GetEnumerator()
        {
            InsertionSort();
              foreach (var w in words)
                yield return w;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

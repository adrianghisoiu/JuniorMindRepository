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
        private Func<Word, Word, int> option;


        public SortedWords(IEnumerable<Word> words) : this (words, (a, b) => a.CompareTo(b)) {}

        public SortedWords(IEnumerable<Word> words, Func<Word, Word, int> option)
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
                    if (option(words[j-1], words[j]) == 1)
                        Swap(j);
                }                           
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

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
        private int count { get; set; }

        public SortedWords(IEnumerable<Word> words)
        {
            this.words = words;
        }

        public Word[] InsertionSort(Word[] words)
        {
           
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (words[j - 1].count < words[j].count)
                    {
                        Word temp = words[j - 1];
                        words[j - 1] = words[j];
                        words[j] = temp;
                    }
                }
            }
            return words;
        }

        public IEnumerator<Word> GetEnumerator()
        {
            throw new NotImplementedException();
            // foreach (var count in words)
            //   yield return count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
   }
}

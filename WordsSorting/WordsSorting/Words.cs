using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WordsSorting
{
    class Words : IEnumerable<Word>
    {
        private Word[] words;

        public Words()
        {
            this.words = new Word[0];
        }

        public void Add(string word)
        {
            if (words.Length == 0)
            {
                Array.Resize(ref words, words.Length + 1);
                words[words.Length - 1] = new Word(word, 1);
            }
            else
            for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].CompareTo(new Word(word, 1)) == 0);
                    words[i].IncrementWord();
            }
        }

        public IEnumerator<Word> GetEnumerator()
        {
            foreach (var word in words)
                yield return word;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

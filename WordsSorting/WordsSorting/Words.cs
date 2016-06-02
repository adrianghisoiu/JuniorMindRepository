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
        private Word[] addWord;
        public void Add(string[] words)
        {
           /* addWord = new Word[words.Length];
            Array.Resize(ref words, words.Length+1);
            words[words.Length - 1] = GetEnumerator();*/
        }

        public IEnumerator<Word> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

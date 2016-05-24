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

        public void Add(string[] words)
        {
            Array.Resize(ref words, words.Length+1);
           // words[words.Length - 1] = GetEnumerator();
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

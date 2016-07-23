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
        public int count;
        
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
    }
}

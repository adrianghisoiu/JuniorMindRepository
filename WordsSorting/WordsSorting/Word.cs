﻿using System;
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

        public string WordToReturn()
        {
            return word + count;
        }
    }
}
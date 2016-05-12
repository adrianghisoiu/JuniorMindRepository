using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsSorting
{
    class Words
    {
        private string[] inputString;

        public Words(string[] inputString)
        {
            this.inputString = inputString;
        }

        public int GetOcurrances(string wordToFind)
        {
            int count = 0;
            for (int i = 0; i < inputString.Length; i++)
                if (wordToFind == inputString[i]) count++;

            return count;
        }


  
    }
}

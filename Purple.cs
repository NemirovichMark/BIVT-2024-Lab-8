using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Purple
    {
        protected static char[] separators = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        protected static char[] numbers = { '0', '1','2','3','4','5','6','7','8','9' };
        private string _input;

        public string Input => _input;

        public Purple(string input)
        {
            _input = input;
        }

        public abstract void Review();

        protected static bool Proverka_na_word(string word)
        {
            int word_length = word.Length;
            int k = 0;
            foreach (char letter in word)
            {
                if(!(numbers.Contains(letter) && separators.Contains(letter)))
                {
                    k++;
                }
            }
            if (k == word_length)
            {
                return true;
            }
            else { return false; }
        }


    }
}

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
        protected static char[] digits = "0123456789".ToArray();
        protected string _input;
        public string Input => _input;

        public Purple(string input)
        {
            _input = input;
        }

        public abstract void Review();

        protected static bool IsLetter(char c)
        {
            return !((separators.Contains(c) || digits.Contains(c) || c == ' '));
        }

        protected static bool IsWord(string s)
        {
            foreach (char c in s)
            {
                if (c != '\'' && c != '-' && (separators.Contains(c) || digits.Contains(c)))
                    return false;
            }
            return true;
        }
    }
}

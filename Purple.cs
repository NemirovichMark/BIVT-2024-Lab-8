using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Purple
    {
        private string _input;
        public string Input => _input;

        protected static readonly char[] punct =
        {
            '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/'
        };

        //конструкторы
        public Purple(string input)
        {
            _input = input;
        }

        public abstract void Review();

        protected bool InWord(char c)
        {
            return char.IsLetter(c) || c== '-' || c == '\'';
        }

        protected bool IsPunct(char c)
        {
            return punct.Contains(c) || c == ' ';
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Blue
    {
        private string _input;
        protected static char[] _punctuation_marks;

        static Blue()
        {
            _punctuation_marks = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };
        }

        public string Input => _input;

        public Blue(string input) { 
            _input = input;
        }

        public abstract void Review();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Purple
    {
        protected static char[] not_letter = { '0', '1', '2', '3','4', '5', '6', '7', '8', '9', 
            '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' }; 
        private string _input;

        public string Input => _input;

        public Purple(string input)
        {
            _input = input;
        }

        public abstract void Review();


    }
}

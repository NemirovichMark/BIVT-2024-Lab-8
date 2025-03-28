using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Purple
    {
        private string _input;

        protected readonly char[] punct_marks = { 
            '.', '!', '?', ',', 
            ':', '\"', ';', '–', 
            '(', ')', '[', ']', 
            '{', '}', '/', ' ' 
        };

        public string Input
        {
            get
            {
                return _input;
            }
        }

        public Purple(string input)
        {
            _input = input;
        }

        protected bool isPunctMark(char c)
        {
            foreach(char ch in punct_marks)
            {
                if(ch == c)
                    return true;
            }
            return false;
        }

        public abstract void Review();
    }
}

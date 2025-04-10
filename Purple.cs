using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Purple
    {
        private string _string;
        public string Input => _string;
        protected char[] sss = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };
        public Purple(string str)
        {
            if (str == null) return;
            _string = str;
        }
        public abstract void Review();
    }
}

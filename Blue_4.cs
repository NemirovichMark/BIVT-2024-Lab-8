using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_4 : Blue 
    {
        private int _output;

        public Blue_4(string input) : base(input) { 
            _output = 0;
        }

        public int Output => _output;

        public override void Review()
        {
            if (String.IsNullOrEmpty(this.Input)) return;

            string[] splitted_text = this.Input.Split(_punctuation_marks);
            foreach (string word in splitted_text) {
                if (!String.IsNullOrEmpty(word) && char.IsDigit(word[0])) {
                    int cur = 0;
                    foreach (char c in word)
                    {
                        if (char.IsDigit(c)) {
                            cur *= 10;
                            cur += ((int)c - 48);
                        }
                    }
                    _output += cur;
                }
            }
        }

        public string ToString() {
            string result = "" + _output;
            return result;
        }
    }
}

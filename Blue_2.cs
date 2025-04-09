using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_2 : Blue
    {
        private string _to_delete;
        private string _output;
        private static char[] _punctuation_marks;

        static Blue_2()
        {
            _punctuation_marks = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };
        }

        public string Output => _output;

        public Blue_2(string input, string to_delete) : base(input) {
            _to_delete = to_delete;
            _output = "";
        }

        public override void Review()
        {
            if (String.IsNullOrEmpty(_to_delete) || String.IsNullOrEmpty(this.Input)) return;
            string[] splitted_text = this.Input.Split(' ');
            foreach (string word in splitted_text) {

                if (!(word.ToLower().Contains(_to_delete.ToLower())))
                {
                    _output += word + " ";
                }
                //else if (!(char.IsLetter(word[word.Length - 1]) || word[word.Length - 1] == '`' || word[word.Length - 1] == '-')) {
                //    _output = _output.Remove(_output.Length - 1);
                //    _output += word[word.Length - 1] + " ";
                //}
                else if (_punctuation_marks.Contains(word[0]) && _punctuation_marks.Contains(word[word.Length - 1])) {
                    int first = -1; int last = word.Length - 1;
                    for (int i = 0; i < word.Length; i++) {
                        if (Char.IsLetter(word[i]) && first == -1) { first = i; }
                        if (Char.IsLetter(word[i])) { last = i; }
                    }
                    _output += word.Substring(0, first) + word.Substring(last + 1) + " ";
                }
            }
            _output = _output.Remove(_output.Length - 1);
        }

        public string ToString() {
            //if (String.IsNullOrEmpty(this.Input) || String.IsNullOrEmpty(this._output)) return null;
            return _output;
        }
    }
}

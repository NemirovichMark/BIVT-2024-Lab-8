using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_3 : Blue
    {
        private (char, double)[] _output;
        private (char, int)[] _counts;

        public (char, double)[] Output => _output;

        public Blue_3(string input) : base(input) {
            _output = new (char, double)[0];
            _counts = new (char, int)[0];
        }

        private void SortFreq() {
            if (_output == null) return;
            (char, double)[] sortedTuples = _output.OrderByDescending(t => t.Item2).ThenBy(t => t.Item1).ToArray();
            _output = sortedTuples;
        }

        private void Count(char c) {
            if (_counts.Length == 0) {
                Array.Resize(ref _counts, 1);
                _counts[0] = (c, 1);
                return;
            }
            bool found = false;
            for (int i = 0; i < _counts.Length; i++) {
                if (_counts[i].Item1 == c) {
                    _counts[i].Item2++;
                    found = true;
                }
            }
            if (!found) {
                Array.Resize(ref _counts, _counts.Length + 1);
                _counts[_counts.Length - 1] = (c, 1);
            }
        }

        private void CalcFreq((char, int)[] counts, int word_count) {
            if (word_count == 0) { return; }
            Array.Resize(ref _output, counts.Length);
            for (int i = 0; i < counts.Length; i++) { 
                _output[i] = (counts[i].Item1, (counts[i].Item2 / (double)word_count) * 100.0);
            }
        }

        public override void Review()
        {
            if (String.IsNullOrEmpty(this.Input)) return;
            string[] splitted_text = this.Input.Split();
            int word_count = splitted_text.Length;
            char c;
            foreach (string word in splitted_text) {
                c = word.ToLower()[0];
                //if (char.IsLetter(c) || c == '(' && char.IsLettesr(word.ToLower()[1]))
                //{
                //    if (char.IsLetter(c)) Count(c);
                //    else Count(word.ToLower()[1]);
                //}
                //else {
                //    word_count--;
                //}
                if (char.IsLetter(c)) Count(c);
                else if ((c == '(' && char.IsLetter(word.ToLower()[1])) || (c == '"' && char.IsLetter(word.ToLower()[1]))) Count(word.ToLower()[1]);
                else word_count--;
            }
            CalcFreq(_counts, word_count);
            SortFreq();
        }

        public string ToString() {
            string result = "";
            foreach ((char, double) t in _output) {
                result += $"{t.Item1} - {t.Item2:F4}\n";
            }
            return result;
        }
    }
}

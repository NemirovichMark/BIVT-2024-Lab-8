using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        private string[] _output;

        public string[] Output => _output;

        public Blue_1(string input) : base(input) {
            _output = new string[0];
        }

        private void AddToOutput(string s) { 
            Array.Resize(ref _output, _output.Length + 1);
            _output[_output.Length - 1] = s;
        }

        private void MySplit(string input) {
            while (!String.IsNullOrEmpty(input)) {
                int row_length = Math.Min(50, input.Length);
                if (row_length < 50 || input.Length == 50) {
                    AddToOutput(input.Substring(0, row_length));
                    input = "";
                }
                else { 
                    for (int i = row_length; i >= 0; i--) {
                        if (input[i] == ' ' || input[i] == '\n') {
                            row_length = i; break;
                        }
                    }
                    AddToOutput(input.Substring(0, row_length));
                    input = input.Substring(row_length + 1);
                }
            }
        }

        public override void Review()
        {
            // if (String.IsNullOrEmpty(this.Input)) { return; }
            MySplit(this.Input);
        }

        public string ToString() {
            if (String.IsNullOrEmpty(this.Input) || _output == null) { return null; }
            string result = "";
            foreach (string s in _output) {
                if (String.IsNullOrEmpty(s)) break;
                result += s + '\n';
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
    }
}

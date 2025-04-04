using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private string _output;
        public string Output => _output;
        public Purple_1(string input) : base(input) {}
        public override void Review()
        {
            if (_input == null) return;
            var arr = _input.Split(separators.Append(' ').ToArray());
            var ans = new StringBuilder();
            int ind = -1;
            foreach (var word in arr)
            {
                if (IsWord(word))
                    ans.Append(word.Reverse().ToArray());
                else 
                    ans.Append(word);
                ind += word.Length + 1;
                if (ind < _input.Length)
                    ans.Append(_input[ind]);
            }
            _output = ans.ToString();
        }

        public override string ToString()
        {
            return _output;
        }
    }
}

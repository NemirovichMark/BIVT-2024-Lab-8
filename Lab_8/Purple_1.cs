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

        public Purple_1(string input) : base(input) {
            _output = default(string);
        }
        public override void Review()
        {
            string _input = Input;
            if (_input == null)
                return;

            char[] _inputArr = _input.ToCharArray();

            int l = 0, r = 0;
            while (l < _inputArr.Length  && r < _inputArr.Length)
            {
                while (l < _inputArr.Length && isPunctMark(_inputArr[l]))
                {
                    l++;
                }
                r = l + 1;
                while (r < _inputArr.Length && !isPunctMark(_inputArr[r]))
                {
                    r++;
                }

                if (l < _inputArr.Length && char.IsNumber(_inputArr[l]))
                {
                    l = r;
                    continue;
                }

                for (int i = 0; i < (r - l) / 2; i++)
                {
                    (_inputArr[l + i], _inputArr[r - 1 - i]) = (_inputArr[r - 1 - i], _inputArr[l + i]);
                }
                l = r;
            }

            _output = "";

            for (int i = 0; i < _inputArr.GetLength(0); i++)
            {
                _output += _inputArr[i];
            }
        }
        public override string ToString() { return _output; }
    }
}


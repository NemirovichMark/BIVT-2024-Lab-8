using System;
using System.Linq;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private (string, char)[] _codes;

        public (string, char)[] Codes => _codes;

        public Purple_4(string input, (string, char)[] codes) : base(input)
        {
            _codes = codes;
        }
        public override void Review()
        {
            if (_input == null || _codes == null) return;
            string result = _input;
            for (int i = 0; i < _codes.Length; i++)
            {
                result = result.Replace(_codes[i].Item2.ToString(), _codes[i].Item1);
            }
            _output = result;

        }

        public override string ToString() => _output;
    }
}

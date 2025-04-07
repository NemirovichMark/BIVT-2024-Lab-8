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
                var (pair, code) = _codes[i];
                int index = 0;
                while ((index = result.IndexOf(code, index)) != -1)
                {
                    result = result.Remove(index, 1);
                    result = result.Insert(index, pair);
                    index += 2;
                }
            }

            _output = result;
        }

        public override string ToString() => _output;
    }
}

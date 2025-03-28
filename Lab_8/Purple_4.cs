using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4: Purple
    {
        private string _output;
        private (string, char)[] _codes;
        public string Output => _output;
        public Purple_4(string input, (string, char)[]codes) : base(input)
        {
            _output = default(string);
            _codes = codes;

        }
        public override void Review()
        {
            string _input = Input;
            if (_input == null)
                return;

            DecodeText(_input);
        }

        private void DecodeText(string compressedText)
        {
            char[] decodedChars = compressedText.ToCharArray();

            _output = "";
            for (int i = 0; i < decodedChars.Length; i++)
            {
                bool replaced = false;
                foreach (var code in _codes)
                {
                    if (decodedChars[i] == code.Item2)
                    {
                        replaced = true;
                        _output += code.Item1;
                        break;
                    }
                }
                if (!replaced)
                    _output += decodedChars[i];
            }
        }
        

        public override string ToString() { return _output; }
    }
}

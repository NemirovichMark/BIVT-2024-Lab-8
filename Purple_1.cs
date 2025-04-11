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
        public Purple_1(string input) : base(input) 
        {
            _output = "";
        }
        public override void Review()
        {
            if (_input == null) return;
            var result = new StringBuilder();
            punctuation.Append(' ').ToArray();
            var splited = _input.Split(punctuation);
            int i = 0;
            foreach (string slovo in splited)
            {
                if (IsWord(slovo))
                {
                    char[] perevorot = slovo.ToCharArray();
                    Array.Reverse(perevorot);
                    string naoborot = new string(perevorot);
                    result.Append(naoborot);
                }
                else
                {
                    result.Append(slovo);
                }
                i += slovo.Length + 1;
                if (i < _input.Length)
                {
                    result.Append(_input[i]);
                }
            }

            _output = result.ToString();

        }
        public override string ToString()
        {
            return _output;
        }
    }
}

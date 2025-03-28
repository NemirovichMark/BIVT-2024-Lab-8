using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private (string, char)[] _codes;
        public string Output { get; private set; }
        public Purple_4(string input, (string, char)[] codes) : base(input)
        {
            _codes = codes;
        }

        public override void Review()
        {
            if (_input == null) return;
            StringBuilder sb = new StringBuilder();
            foreach (char c in _input)
            {
                int icode = -1;
                for (int i = 0; i < _codes.Length; i++)
                    if (_codes[i].Item2 == c)
                        icode = i;
                if (icode == -1)
                {
                    sb.Append(c);
                } else
                {
                    sb.Append(_codes[icode].Item1);
                }
            }
            Output = sb.ToString();
        }
        public override string ToString()
        {
            return Output;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        public Purple_4(string input, (string, char)[] codes) : base(input)
        {
            if (codes != null)
            {
                var newArray = new (string, char)[codes.Length];
                Array.Copy(codes, newArray, codes.Length);
                _codes = newArray;
            }
        }
        private string _output;
        private (string, char)[] _codes;
        public string Output => _output;
        public override string ToString()
        {
            return _output;
        }
        public override void Review()
        {
            if (String.IsNullOrEmpty(Input) ||_codes == null) return;
            _output = Input;
            for (int i = 0; i<_codes.Length; i++)
            {
                _output = _output.Replace(_codes[i].Item2.ToString(), _codes[i].Item1);
            }
        }
    }
}

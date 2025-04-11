using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private (string, char)[] _Codes;
        public string Output { get; private set; }
        public Purple_4(string input, (string, char)[] codes) : base(input) { Output = default(string); _Codes = codes; }
        public override void Review()
        {
            if (string.IsNullOrEmpty(Input) || _Codes == null) return;
            Output = Input;

            for (int i = 0; i < _Codes.Length; i++)
            {
                if (_Codes[i].Item1 != null) {
                    Output = Output.Replace(_Codes[i].Item2.ToString(), _Codes[i].Item1);
                }

            }
        }
        public override string ToString()
        {
                
            return Output;

        }
    }
}

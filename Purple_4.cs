using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        public (string, char)[] Codes { get; private set; }
        public string Output { get; private set; }
        public Purple_4(string input, (string, char)[] codes) : base(input) { Output = default(string); Codes = codes; }
        public override void Review()
        {
            if (string.IsNullOrEmpty(Input) || Codes == null) return;
            Output = Input;

            for (int i = 0; i < Codes.Length; i++)
            {
                if (Codes[i].Item1 != null) {
                    Output = Output.Replace(Codes[i].Item2.ToString(), Codes[i].Item1);
                }

            }
        }
        public override string ToString()
        {
                
            return Output;
        }
    }
}

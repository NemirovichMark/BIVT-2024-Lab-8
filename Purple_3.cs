using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {

        private (string, char)[] _codes;
        public (string, char)[] Codes => _codes;
        public string Output { get; private set; }

        
        public Purple_3(string input) : base(input)
        {
            Output = default;
            _codes = new (string, char)[0];            
        }

        public override void Review()
        {
            if (string.IsNullOrEmpty(base.Input)) return;
            Output = Input;
            Array.Resize(ref _codes, 5); int chetchik_5 = 0;

            string[] pairs_of_2l = new string[0];

            for (int i = 0; i < Input.Length - 1; i++) {
                if (not_letter.Contains(Input[i]) == false && not_letter.Contains(Input[i + 1]) == false)
                {
                    var xz = $"{Input[i]}{Input[i+1]}";
                    pairs_of_2l = pairs_of_2l.Append(xz).ToArray();
                }
            }

            pairs_of_2l = pairs_of_2l.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key.ToString()).Take(5).ToArray();

            for (int char1 = 32; char1 <= 126 && chetchik_5 < 5; char1++)
            {
                if (Input.Contains((char)char1) == false)
                {
                    _codes[chetchik_5] = (pairs_of_2l[chetchik_5], (char) char1);
                    chetchik_5++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Output = Output.Replace(Codes[i].Item1, Codes[i].Item2.ToString());
            }


        }
        public override string ToString() {
            return Output;
        }
    }
}

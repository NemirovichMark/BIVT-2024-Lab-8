using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        private string _output;
        private (string, char)[] _codes;

        public string Output => _output;
        public (string, char)[] Codes => ((string, char)[])_codes?.Clone();

        public Purple_3(string input) : base(input)
        {
        }

        public override void Review()
        {
            if (Input == null) return;

            _codes = new (string, char)[0];
            
            if (Input.Length == 0)
            {
                _output = Input;
                return;
            }

            var pairs = new string[Input.Length - 1];

            for (int i = 0; i < Input.Length - 1; i++)
            {
                pairs[i] = String.Concat(Input[i], Input[i + 1]);
            }

            pairs = pairs
                .Where(x => x.All(y => Char.IsLetter(y)))
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Take(5)
                .Select(x => x.Key)
                .ToArray();

            Array.Resize(ref _codes, 5);

            for (int code = 32, i = 0; code <= 126 && i < 5; code++)
            {
                if (!Input.Contains((char)code))
                {
                    _codes[i] = (pairs[i], (char)code);
                    i++;
                }
            }

            _output = Input;

            for (int i = 0; i < 5; i++)
            {
                _output = _output.Replace(Codes[i].Item1, Codes[i].Item2.ToString());
            }
        }

        public override string ToString()
        {
            return Output;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        private char[] signs;
        public string Output {  get; private set; }
        public (string, char)[] Codes { get; private set; }
        public Purple_3(string input) : base(input)
        {
            Codes = new (string, char)[0];
            signs = new char[0];
            for (char c = ' '; signs.Length < 5 && c <= '~' ; c++)
            {
                if (!input.Contains(c))
                    signs = signs.Append(c).ToArray();
            }
        }
        public override void Review()
        {
            if (_input == null) return;
            string[] combs = new string[0];
            for (int i = 0; i < _input.Length - 1; i++)
            {
                if (IsLetter(_input[i]) && IsLetter(_input[i + 1]))
                    combs = combs.Append($"{_input[i]}{_input[i + 1]}").ToArray();
            }
            var codes = combs.GroupBy((x) => (x))
                .Select(x => (x.Key.ToString(), x.Count()))
                .OrderByDescending(x => x.Item2)
                .Select(x => x.Item1)
                .Take(5)
                .ToArray();

            StringBuilder ans = new StringBuilder();
            string text = _input;
            for (int j = 0; j < codes.Length; j++)
            {
                var code = codes[j];
                int i;
                for (i = 0; i < text.Length - 1; i++)
                {
                    string str = $"{text[i]}{text[i + 1]}";
                    if (str == code)
                    {
                        ans.Append(signs[j]);
                        i++;
                    } else
                    {
                        ans.Append(text[i]);
                    }
                }
                if (i == text.Length - 1)
                    ans.Append(text[i]);

                text = ans.ToString();
                ans = new StringBuilder();
            }
            Output = text;
            
            for (int i = 0; i < codes.Length && i < signs.Length; i++)
            {
                Codes = Codes.Append((codes[i], signs[i])).ToArray();
            }
        }

        public override string ToString()
        {
            return Output;
        }
    }
}

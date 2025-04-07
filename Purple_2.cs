using System;
using System.Linq;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private new string[] _output;

        public new string[] Output => _output;
        public Purple_2(string input) : base(input) { }

        public override void Review()
        {
            if (_input == null) return;

            string[] words = _input.Split(' ');
            string[] lines = new string[0];
            string line = "";
            
            for (int i = 0; i < words.Length - 1; i++)
            {
                line += words[i] + " ";
                if (words[i + 1].Length + line.Length > 50)
                {
                    string [] newWords = line.Split(' ');
                    int needSpaces = 50 - line.Trim().Length;
                    while (needSpaces > 0)
                    {
                        for (int j = 0; j < newWords.Length - 2; j++)
                        {
                            if (needSpaces <= 0) break;
                            newWords[j] = newWords[j] + " ";
                            needSpaces--;
                        }
                    }
                    line = string.Join(" ", newWords);
                    Array.Resize(ref lines, lines.Length + 1);
                    lines[lines.Length - 1] = line.Trim();
                    line = "";
                }
            };

            _output = lines;
            
        }


        public override string ToString() => string.Join("\n", _output);
    }
}
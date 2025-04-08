using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string[] _output;
        public string[] Output => _output;

        public Purple_2(string input) : base(input) { _output = default; }



        public override void Review()
        {
            if (string.IsNullOrEmpty(base.Input)) return;
            string[] answer = new string[0];
            string inputing = Input;
            while (inputing.Length > 50) {
                int spaceX = inputing.Substring(0, 51).LastIndexOf(' ');
                if (spaceX == -1)
                {
                    spaceX = 50; // ищем дальше
                }
                string line_into_inputing = inputing.Substring(0, spaceX).Trim();
                inputing =  inputing.Substring(spaceX+1).Trim();
                line_into_inputing = Shire(line_into_inputing, 50);
                Array.Resize(ref answer, answer.Length+1);
                answer[answer.Length-1] =line_into_inputing;
            }

            if (inputing.Length > 0)
            {
        
                if (inputing.Length < 50 && inputing.Contains(' '))
                {
                    inputing = Shire(inputing, 50);
                }
                else if (inputing.Length < 50)
                {
                    inputing += new string(' ', 50 - inputing.Length);
                }
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = inputing;
            }
            _output = answer.ToArray();

        }
        private string Shire(string line, int length)
        {
            if (line == null) return default;
            if (line.Length == length)
                return line;

            string[] words = line.Split(' ');

            if (words.Length <= 1)
                return line + new string(' ', Math.Max(0, length - line.Length));

            int all_spaces_need = length - line.Length + (words.Length - 1); // + пробелы между словами
            int between_space = all_spaces_need / (words.Length - 1) - 1;
            int extra_space = all_spaces_need % (words.Length - 1);

            StringBuilder done_line = new StringBuilder(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                int extra = i <= extra_space ? 1 : 0;
                int trash = between_space + extra;
                done_line.Append(new string(' ', trash + 1)); // +1 для исходного пробела
                done_line.Append(words[i]);
            }

            return done_line.ToString();
        }
        public override string ToString()
        {
            var outputing = new StringBuilder();

            foreach (var row in Output) {
                outputing.AppendLine(row);
            }

            return outputing.ToString().TrimEnd(); 

        }
    }
}


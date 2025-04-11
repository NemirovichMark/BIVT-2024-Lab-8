using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

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


            _output = new string[0];
            string inputing = Input;

            while (inputing.Length > 50) {

                int line_ind = 50;

                while (inputing[line_ind] != ' ')
                {
                    line_ind--;

                    if (line_ind < 0)
                    {
                        _output = _output.Append(inputing).ToArray();
                        break;
                    }
                }

                string line_till_line_ind = inputing.Substring(0, line_ind);
                string _50_symbols = Shire(line_till_line_ind, 50);

                _output = _output.Append(_50_symbols).ToArray();
                inputing = inputing.Substring(line_ind + 1);
            }

            if (inputing.Length > 0)
            {
                var ostatok = Shire(inputing,50);
                _output = _output.Append(ostatok).ToArray();
            }

        }
        private string Shire(string line, int length)
        {
            if (line == null) { return default; }
            if (line.Length == length) { return line; }

            int amount_of_spaces = 0;
            for (int i = 0; i < line.Length; i++) {
                if (line[i] == ' ') { amount_of_spaces++; }   
            }

            if (amount_of_spaces == 0) { 
                return line;
            }
            else
            {
                int between_space = (50 - line.Length) / amount_of_spaces;
                int extra_space = (50 - line.Length) % amount_of_spaces;

                string plus_spaces_for_every_spaces = "";
                
                for (int i = 0; i < between_space; i++)
                {
                    plus_spaces_for_every_spaces += " ";
                }

                var new_line = new StringBuilder();

                foreach (var symbol in line)
                {
                    if (symbol == ' ')
                    {
                        if (extra_space > 0)
                        {
                            new_line.Append(' ');
                            extra_space--;
                        }
                        new_line.Append(plus_spaces_for_every_spaces);
                    }
                    new_line.Append(symbol);
                }

                return new_line.ToString();
            }
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


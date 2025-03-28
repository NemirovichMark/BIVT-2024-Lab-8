using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string[] _rows;
        public string[] Output => _rows;
        public Purple_2(string input) : base(input)
        {
            _rows = new string[0];
        }
        public override void Review()
        {
            if (_input == null) return;

            string text = _input;
            while (text.Length > 50)
            {
                int ind = 50;
                while (ind >= 0 && text[ind] != ' ') ind--;
                if (ind == -1)
                {
                    _rows = _rows.Append(text).ToArray();
                    break;
                }
                string newRow = text.Substring(0, ind);
                string formatedRow = FormatString(newRow);
                _rows = _rows.Append(formatedRow).ToArray();
                text = text.Substring(ind + 1);
            }
            if (text.Length > 0)
                _rows = _rows.Append(FormatString(text)).ToArray();
        }
        public override string ToString()
        {
            string ans = "";
            foreach (var s in _rows) { ans += s + '\n'; }
            ans = ans.Remove(ans.Length - 1, 1);
            return ans;
        }

        private string FormatString(string s)
        {
            int sp = s.Count(x => x == ' ');
            if (sp == 0) return s;
            int forAll = (50 - s.Length) / sp;
            int extra = (50 - s.Length) % sp;
            string addition = "";
            for (int i = 0; i < forAll; i++)
                addition += " ";

            StringBuilder ans = new StringBuilder();
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    if (extra > 0)
                    {
                        ans.Append(' ');
                        extra--;
                    }
                    ans.Append(addition);
                }
                ans.Append(c);
            }
            return ans.ToString();
        }
    }
}

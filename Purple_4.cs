using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private string _ans = null;
        private string s = null;
        private (string, char)[] _codes = null;
        public string Output
        {
            get
            {
                return _ans;
            }
        }
        public (string, char)[] Codes
        {
            get
            {
                if (_codes == null) return null;
                (string, char)[] lcodes = new (string, char)[_codes.Length];
                for (int i = 0; i < lcodes.Length; i++)
                {
                    lcodes[i] = _codes[i];
                }
                return lcodes;
            }
        }
        public Purple_4(string str, (string, char)[] codes) : base(str)
        {
            s = str;
            _codes = codes;
        }
        public override void Review()
        {
            if (s == null || _codes == null) return;
            for (int i = 0; i < _codes.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == _codes[i].Item2)
                    {
                        string ss = null;
                        if (j + 1 <= s.Length - 1)
                        {
                            ss = s.Substring(0, j) + _codes[i].Item1 + s.Substring(j + 1);
                        }
                        else
                        {
                            ss = s.Substring(0, j) + _codes[i].Item1;
                        }
                        s = ss;
                    }
                }
            }
            _ans = s;
            
        }
        public override string ToString()
        {
            return _ans;
        }
    }
}

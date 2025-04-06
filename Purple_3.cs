using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
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
                for (int i = 0; i < _codes.Length; i++)
                {
                    lcodes[i] = _codes[i];
                }
                return lcodes;
            }
        }
        public Purple_3(string str) : base(str)
        {
            s = str;
        }
        public override void Review()
        {
            if (s == null) return;
            string[] un = new string[0];
            int[] uncount = new int[0];
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (char.IsLetter(s[i]) && char.IsLetter(s[i + 1]))
                {
                    int flag = 0;
                    string lstr = null;
                    lstr += s[i].ToString() + s[i + 1].ToString();
                    for (int j = 0; j < un.Length; j++)
                    {
                        if (un[j] == lstr)
                        {
                            flag = 1;
                            uncount[j]++;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        un = un.Append(lstr).ToArray();
                        uncount = uncount.Append(1).ToArray();
                    }
                }
            }
            for (int i = 0; i < un.Length; i++)
            {
                for (int j = 0; j < un.Length - 1; j++)
                {
                    if (uncount[j] < uncount[j + 1])
                    {
                        int t = uncount[j];
                        uncount[j] = uncount[j + 1];
                        uncount[j + 1] = t;
                        string tt = un[j];
                        un[j] = un[j + 1];
                        un[j + 1] = tt;
                    }
                }
            }

            char[] unchar = new char[0];
            for (int i = 32; i <= 126 && unchar.Length < 5; i++)
            {
                int flag = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == (char)i)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    unchar = unchar.Append((char)i).ToArray();
                }
            }

            _codes = new (string, char)[Math.Min(Math.Min(5, un.Length), unchar.Length)];
            for (int i = 0; i < _codes.Length; i++)
            {
                _codes[i] = (un[i], unchar[i]);
            }

            for (int j = 0; j < _codes.Length; j++)
            {
                int flag = 1;
                while (flag != 0)
                {
                    flag = 0;
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        string lstr = null;
                        lstr += s[i].ToString() + s[i + 1].ToString();
                        if (lstr == _codes[j].Item1)
                        {
                            flag = 1;
                            string ss = "";
                            if (i + 2 <= s.Length - 1)
                            {
                                ss = s.Substring(0, i) + _codes[j].Item2 + s.Substring(i + 2);
                            }
                            else
                            {
                                ss = s.Substring(0, i) + _codes[j].Item2;
                            }
                            s = ss;
                            break;
                        }
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

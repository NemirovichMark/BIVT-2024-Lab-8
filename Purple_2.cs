using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string[] _ans = null;
        private string s = null;
        private int max = 50;
        public string[] Output
        { get 
            {
                if (_ans == null) return null;
                string[] s = new string[0];
                for (int i = 0; i < _ans.Length; i++)
                {
                    s = s.Append(_ans[i]).ToArray();
                }
                return s;
            } 
        }
        public Purple_2(string str) : base(str)
        {
            s = str;
        }
        public override void Review()
        {
            if (s == null) return;
            var p = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] ans0 = new string[0];
            int count = 0;
            for (int i = 0; i < p.Length; i++)
            {
				if (ans0.Length == 0)
                {
                    count += p[i].Length;
                    ans0 = ans0.Append(p[i]).ToArray();
				}
                else
                {
					if (count + 1 + p[i].Length <= max)
                    {
						count += 1 + p[i].Length;
                        ans0 = ans0.Append(p[i]).ToArray();
                    }
                    else 
                    {
                        string ans = null;
                        if (ans0.Length >= 2)
                        {
                            int nspace = max - count;
                            int space = nspace / (ans0.Length - 1);
                            int fi = nspace % (ans0.Length - 1);
                            for (int j = 0; j < ans0.Length; j++, fi--)
                            {
                                ans += ans0[j];
                                if (j != ans0.Length - 1)
                                {
                                    ans += new string(' ', space + 1);
                                    if (fi > 0)
                                        ans += ' ';
                                }
                            }
                        }
                        else
                        {
                            ans = ans0[0] + (new string(' ', max - count));
                        }
                        if (ans != null && ans != "")
                        {
                            _ans = _ans.Append(ans).ToArray();
                        }

						ans0 = new string[0];
						count = 0;
						count += p[i].Length;
						ans0 = ans0.Append(p[i]).ToArray();
					}
                }
            }
			if (ans0 != new string[0])
            {
                string ans = null;
                if (ans0.Length >= 2)
                {
                    int nspace = max - count;
                    int space = nspace / (ans0.Length - 1);
                    int fi = nspace % (ans0.Length - 1);
                    for (int j = 0; j < ans0.Length; j++, fi--)
                    {
                        ans += ans0[j];
                        if (j != ans0.Length - 1)
                        {
                            ans += new string(' ', space + 1);
                            if (fi > 0)
                                ans += ' ';
                        }
                    }
                }
                else
                {
                    ans = ans0[0];
                }
                if (ans != null && ans != "")
                {
                    _ans = _ans.Append(ans).ToArray();
                }
            }
        }
        public override string ToString()
        {
            return string.Join("\n", _ans);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private string _ans = null;
        private string s = null;
        public string Output => _ans;
        public Purple_1(string str) : base(str) 
        { 
            s = str;
        }
        public override void Review()
        {
            if (s == null) return;
            for (int i = 0; i < s.Length;)
            {
                int l = i;
                string ls = "";
                while (!(sss.Contains(s[i])) && i < s.Length)
                {
                    ls += s[i];
                    i++;
                }

                int flag = 0;
                for (int j = 0; j < ls.Length; j++)
                {
                    if (char.IsDigit(ls[j]))
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    continue;
                }


                string ns = null;
                for (int j = ls.Length - 1; j >= 0; j--)
                {
                    ns += ls[j];
                }
                string end = null;
                if (i < s.Length) end = s.Substring(i);
                string news = s.Substring(0, l) + ns + end;
                s = news;
                i++;
            }
            _ans = s;
        }
        public override string ToString()
        {
            return _ans;
        }
    }
}

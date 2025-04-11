using System;
using System.Linq;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        public Purple_1(string input) : base(input) { }
        private string Reverse(string s)
        {
            if (s == null) return null;
            if (s.Length <= 1) return s;

            int start = 0;
            int end = s.Length - 1;
            int flag1 = 0;
            int flag2 = 0;
            string endStr = string.Empty;
            string startStr = string.Empty;
            for(int i = start, j = end; i <= end; i++, j--)
            {
                if (flag1 == 1 && flag2==1) break;
                if (!_allsigns.Contains(s[i]) && flag1 != 1)
                {
                    
                    start = i;
                    flag1 = 1;
                }
                if (_signs.Contains(s[i])) startStr = startStr+s[i];
                if (!_allsigns.Contains(s[j]) && flag2 != 1)
                {
  
                    end = j;
                    flag2 = 1;
                }
                if (_signs.Contains(s[j])) endStr = s[j]+endStr ;
                
            }
            s = s.Substring(start, end-start+1);
            string reversed = new string(s.Reverse().ToArray());
            reversed = reversed.Insert(0, startStr);
            reversed = string.Concat(reversed, endStr);
            return reversed;
            
        }
        public override void Review()
        {

            if (_input == null) return;

            string[] strSplit = Input.Split(' ');
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (HasNumber(strSplit[i])) continue;
                strSplit[i] = Reverse(strSplit[i]);
            }
            _output = String.Join(" ", strSplit).ToString();

        }
    }
}
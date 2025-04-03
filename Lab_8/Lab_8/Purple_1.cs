using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1:Purple
    {
        public Purple_1(string input) : base(input) { }
        private string _output;
        public string Output=>_output;
        public override string ToString()
        {
            return _output;
        }
        private static StringBuilder Reversword(StringBuilder a,int start,int end)
        {
            if (start >= end || end >= a.Length ||a == null) return a;
            for (int i = 0;i <(end-start+1)/2; i++)
            {
                var temp = a[start + i];
                a[start + i] = a[end - i];
                a[end - i] = temp;
            }
            return a;
        }
        public override void Review()
        {
            if (String.IsNullOrEmpty(Input)) return;
            var ans = new StringBuilder(Input);
            int start = -1, end = -1;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == ' ' || punctmarks.Contains(Input[i]) || Char.IsDigit(Input[i]) || (Input[i]=='t' && Char.IsDigit(Input[i-1])))
                {
                    if (start == -1 || end == -1) continue;
                    else
                    {
                        ans = Reversword(ans, start, end);
                        start = -1;end = -1;
                    }
                }
                else
                {
                    if (start == -1)
                    {
                        start = i; end = i;
                    }
                    else end++;
                }
            }
            _output = ans.ToString();
        }

    }
}

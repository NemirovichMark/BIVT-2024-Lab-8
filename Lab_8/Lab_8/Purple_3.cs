using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        public Purple_3(string input) : base(input) { }
        private string _output;
        private (string, char)[] _codes;
        public (string, char)[] Codes
        {
            get
            {
                if (_codes == null) return null;
                var newArray = new (string, char)[_codes.Length];
                Array.Copy(_codes, newArray, _codes.Length);
                return newArray;
            }
        }
        public string Output => _output;
        public override string ToString()
        {
            return _output;
        }
        private static int CountSubstring(string input, string substring)
        {
            if (String.IsNullOrEmpty(input)) return 0;
            int count = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i].ToString() + input[i + 1].ToString() == substring)
                    count++;
               
            }
            return count;
        }
        public override void Review()
        {
            if (String.IsNullOrEmpty(Input)) return;
            int start = -1, end = -1;
            HashSet<string> allpar = new HashSet<string> { };
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == ' ' || punctmarks.Contains(Input[i]) || Char.IsDigit(Input[i]) || (Input[i] == 't' && Char.IsDigit(Input[i - 1])))
                {
                    if (start == -1 || end == -1) continue;
                    else
                    {
                        string temp = Input.Substring(start, end - start + 1);
                        for (int j = 0; j < temp.Length-1; j++)
                        {
                            allpar.Add(temp.Substring(j, 2));
                        }
                        start = -1; end = -1;
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
            string[] allparstr = allpar.ToArray();
            int[] allparcout = new int[allparstr.Length];
            for (int i = 0;i < allparstr.Length; i++)
            {
                allparcout[i] = CountSubstring(Input, allparstr[i]) ;
            }
            for (int i = 0; i<allparstr.Length;i++)
            {
                for (int j = 0; j < allparstr.Length - i - 1; j++)
                {
                    if (allparcout[j] < allparcout[j + 1])
                    {
                        var temp = allparcout[j];
                        allparcout[j] = allparcout[j + 1];
                        allparcout[j + 1] = temp;
                        var temp2 = allparstr[j];
                        allparstr[j] = allparstr[j + 1];
                        allparstr[j + 1] = temp2;
                    }
                }
            }
            _codes = new (string, char)[5];
            int k = 0;
            for (int i = 32; i < 127;i++)
            {
                if (k == 5) break;
                if (Input.Count(s => s == (char)i) == 0)
                {
                    _codes[k].Item2 = (char)i;
                    k++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                _codes[i].Item1 = allparstr[i];
            }
            _output = Input;
            for (int i= 0; i< 5; i++)
            {
                _output = _output.Replace(_codes[i].Item1, _codes[i].Item2.ToString());
            }
        }
    }
}

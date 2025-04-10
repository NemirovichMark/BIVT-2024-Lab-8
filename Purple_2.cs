using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private const int REQUIRED_LENGTH = 50;
        public string[] Output { get; private set; }

        public Purple_2(string input) : base(input) { }

        private void AddSpaces() {
            for (int i = 0; i < Output.Length; ++i)
            {
                int notEnough = REQUIRED_LENGTH - Output[i].Length;
                string[] arr = Output[i].Split(' ');
                int spaces = arr.Length - 1;
                for(int j = 0; j < arr.Length - 1; ++j)
                {
                    int toAdd = (notEnough + spaces - 1) / spaces;
                    arr[j] = arr[j] + new string(' ', toAdd);
                    notEnough -= toAdd;
                    --spaces;
                }
                Output[i] = string.Join(" ", arr);
            }
        }
        public override void Review()
        {
            string[] ans = new string[0];
            string[] arr = Input.Split(' ');
            int len = 0;
            foreach (string s in arr) {
                if (len == 0 || s.Length > REQUIRED_LENGTH - (len + 1))
                {
                    ans = ans.Append(s).ToArray();
                    len = s.Length;
                }
                else
                { 
                    ans[ans.Length - 1] = ans[ans.Length - 1] + " " + s;
                    len += s.Length + 1;
                }
            }
            Output = ans;
            AddSpaces();
        }

        public override string ToString()
        {
            if (Output == null || Output.Length == 0) return "";
            StringBuilder res = new StringBuilder(Output[0]);
            foreach (string s in Output.Skip(1)) {
                res.Append("\n" + s);
            }
            return res.ToString();
        }
    }
}

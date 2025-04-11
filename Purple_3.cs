using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        public string Output { get; private set; }
        public (string, char)[] Codes { get; private set; }

        private char[] replacementCodes;
        public Purple_3(string input) : base(input) {
            Codes = new (string, char)[0];
        }

        private void findCodes() {
            if (Output == null) return;
            replacementCodes = new char[0];
            for(int i = 32; i <= 126; ++i)
            {
                if (replacementCodes.Length == 5) return;
                if (!Output.Contains((char)i)) replacementCodes = replacementCodes.Append((char)i).ToArray();
            }
        }

        private int CountIn(string t)
        {
            if(Output == null) return 0;
            int res = 0;
            for(int i = Output.IndexOf(t, 0); i < Output.Length && i != -1;)
            {
                ++res;
                i = Output.IndexOf(t, i + 1);
            }
            return res;
        }

        private string[] FindPairs(string[] mas)
        {
            if (mas == null) return new string[0];
            (string, int)[] ans = new (string, int)[5];
            for(int i = 0; i < 5; ++i)
            {
                ans[i] = ("", 0);
            }
            for (int i = 0; i < mas.Length; ++i) {
                if (mas[i] == null) continue;
                for (int j = 0; j < mas[i].Length - 1; ++j) {
                    if (char.IsLetter(mas[i][j]) && char.IsLetter(mas[i][j + 1])) {
                        string temp = string.Concat(mas[i][j], mas[i][j + 1]);
                        (string, int) t = (temp, CountIn(temp));
                        if (ans.Contains(t)) continue;
                        ans = ans.Append(t).ToArray();
                        ans = ans.OrderByDescending(answer => answer.Item2).ToArray();
                        ans = ans.Take(ans.Length - 1).ToArray();
                    }
                }
            }
            string[] res = new string[5];
            for(int i = 0; i < 5; ++i)
            {
                if (ans[i].Item2 != 0) res[i] = ans[i].Item1;
                else
                {
                    res = res.Take(i).ToArray();
                    break;
                }
            }
            return res;
        }
        public override void Review()
        {
            Output = Input;
            if(Output == null) return;
            findCodes();
            string[] pairs = FindPairs(Output.Split(' '));
            if (pairs == null) return; 
            for(int i = 0; i < pairs.Length; ++i)
            {
                Output = Output.Replace(pairs[i], replacementCodes[i].ToString());
                Codes = Codes.Append((pairs[i], replacementCodes[i])).ToArray();
            }
        }

        public override string ToString()
        {
            return Output;
        }
    }
}

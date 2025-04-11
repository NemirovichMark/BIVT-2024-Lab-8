using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        public string Output {  get; private set; }

        public Purple_1(string input) : base(input) { }

        private bool isWord(string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(c => char.IsLetter(c) || char.IsSeparator(c) || char.IsPunctuation(c));
        }

        private void findBoundaries(string s, out int start, out int finish)
        {
            start = 0; finish = s.Length;
            foreach (char c in s)
            {
                if (!(char.IsLetter(c) || c == '-' || c == '’')) ++start;
                else break;
            }
            for (int j = s.Length - 1; j >= 0; --j)
            {
                if (!(char.IsLetter(s[j]) || s[j] == '-' || s[j] == '’')) finish = j;
                else break;
            }
        }

        public override void Review()
        {
            if (String.IsNullOrEmpty(Input)) return;
            string[] arr = Input.Split(' ');
            for (int i = 0; i < arr.Length; ++i) {
                if (string.IsNullOrEmpty(arr[i]) || !isWord(arr[i])) continue;
                findBoundaries(arr[i], out int start, out int finish);
                if (start < finish && finish != arr.Length)
                {
                    string mid = arr[i].Substring(start, finish - start);
                    arr[i] = arr[i].Substring(0, start) + new string(mid.Reverse().ToArray()) + arr[i].Substring(finish);
                }
            }
            Output = string.Join(" ", arr);
        }

        public override string ToString()
        {
            return Output;
        }
    }
}

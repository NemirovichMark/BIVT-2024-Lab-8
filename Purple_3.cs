using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        public string Output { get; private set; }
        public (string, char)[] Codes { get; private set; }

        public Purple_3(string input) : base(input)
        {
            Codes = new (string, char)[0];
        }
        public override void Review()
        {
            if (Input == null) return;
            var pairs = CountPairs(Input);
            var top5pairs = pairs.GroupBy(p => p.Item1).Select(g => new { Pair = g.Key, TotalCount = g.Sum(x => x.Item2)}).OrderByDescending(x => x.TotalCount).ThenBy(x => x.Pair).Take(5).Select(x => x.Pair).ToArray();
            Codes = SetCodes(Input, top5pairs);
            Output = Szhatie(Input, Codes);

        }
        private (string Pair, int Count)[] CountPairs(string text)
        {
            var pairs = new (string, int)[text.Length - 1];
            int pairCount = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (!IsLetter(text[i]) || !IsLetter(text[i + 1])) continue;
                string pair = text.Substring(i, 2);
                bool found = false;

                for (int j = 0; j < pairCount; j++)
                {
                    if (pairs[j].Item1 == pair)
                    {
                        pairs[j].Item2++;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    pairs[pairCount++] = (pair, 1);
                }
            }
            Array.Resize(ref pairs, pairCount);
            return pairs;
        }
        private (string, char)[] SetCodes(string text, string[] pairs)
        {
            var codes = new (string, char)[pairs.Length];
            char code = (char)32;
            bool[] usedChars = new bool[127];
            foreach (char c in text)
            {
                if (c >= 32 && c <= 126)
                    usedChars[c] = true;
            }
            for (int i = 0; i < pairs.Length && pairs[i] != null; i++)
            {
                while (code <= 126 && usedChars[code])
                {
                    code++;
                }

                if (code > 126) break;

                codes[i] = (pairs[i], code);
                usedChars[code] = true;
            }
            return codes;
        }
        private string Szhatie(string text, (string Pair, char Code)[] codes)
        {
            var result = new StringBuilder(text);
            foreach (var obj in codes)
            {
                if(obj.Pair != null)
                {
                    result = result.Replace(obj.Pair, obj.Code.ToString());
                }
                
            }
            return result.ToString();
        }
        public override string ToString()
        {
            return Output;
        }
    }
}

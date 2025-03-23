using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8 {
    class Purple_3 : Purple
    {
        private string _output = "";
        private (string, char)[] _codes = new (string, char)[0];
    
        public string Output => _output;
        public (string, char)[] Codes => _codes;
    
        public Purple_3(string input) : base(input) {}
    
        public override void Review()
        {
            if (Input == null) return;
            
            int maxPairsCount = Input.Length * 2;
            string[] temp = new string[maxPairsCount];
            int pairCnt = 0;
        
            for (int i = 0; i < Input.Length - 1; i++)
            {
                if (char.IsLetter(Input[i]) && char.IsLetter(Input[i + 1])) temp[pairCnt++] = Input.Substring(i, 2);
            }

            string[] pairs = new string[pairCnt];
            Array.Copy(temp, pairs, pairCnt);
            
            var pairFrequency = pairs
                .GroupBy(p => p)
                .Select(g => new { Pair = g.Key, Count = g.Count(), FirstIndex = Input.IndexOf(g.Key) })
                .OrderByDescending(p => p.Count)
                .ThenBy(p => p.FirstIndex)
                .Take(5)
                .ToArray();
            
            char[] allCodes = new char[95];
            int codeCnt = 0;
        
            for (int i = 32; i <= 126; i++)
            {
                char c = (char)i;
                if (Input.IndexOf(c) == -1)
                {
                    allCodes[codeCnt++] = c;
                    if (codeCnt >= 5) break;
                }
            }
            
            _codes = new (string, char)[Math.Min(codeCnt, Math.Min(pairFrequency.Length, 5))];
            for (int i = 0; i < _codes.Length; i++) _codes[i] = (pairFrequency[i].Pair, allCodes[i]);
            
            StringBuilder result = new StringBuilder(Input);
            foreach ((string, char) code in _codes) result = result.Replace(code.Item1, code.Item2.ToString());
            _output = result.ToString();
        }

        public override string ToString() => Output;
    }
}
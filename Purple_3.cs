using System;
using System.Linq;
using System.Text;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        private (string, char)[] _codes;

        public (string, char)[] Codes => _codes;

        public Purple_3(string input) : base(input) { }
        
        public override void Review()
        {
            if (_input == null) return;

            (string Pair, int Count)[] pairs = new (string, int)[_input.Length];
            int uniquePairsCount = 0;

            for (int i = 0; i < _input.Length - 1; i++)
            {
                string pair = _input.Substring(i, 2);
                bool found = false;
                if (char.IsLetter(pair[0]) && char.IsLetter(pair[1]))
                {
                    for (int j = 0; j < uniquePairsCount; j++)
                    {
                        if (pairs[j].Pair == pair)
                        {
                            pairs[j].Count++;
                            found = true;
                            break;
                        }
                    }

                    if (!found && uniquePairsCount < pairs.Length)
                    {
                        pairs[uniquePairsCount] = (pair, 1);
                        uniquePairsCount++;
                    }
                }
            }

            _codes = new (string, char)[Math.Min(5, uniquePairsCount)];

            for (int i = 0; i < _codes.Length; i++)
            {
                int maxCount = 0;
                int maxIndex = -1;

                for (int j = 0; j < uniquePairsCount; j++)
                {
                    if (pairs[j].Count > maxCount)
                    {
                        maxCount = pairs[j].Count;
                        maxIndex = j;
                    }
                }
                if (maxIndex != -1)
                {
                    int symbol = i + 33;
                    _codes[i] = (pairs[maxIndex].Pair,'_');
                    pairs[maxIndex].Count = -1;
                }
            }
            bool[] usedSymbols = new bool[126 - 33 + 1];
            foreach (char c in _input)
            {
                int asciiCode = (int)c;
                if (asciiCode >= 33 && asciiCode <= 126)
                {
                    usedSymbols[asciiCode - 33] = true;
                }
            }

            int k = 33;
            for (int i = 0; i < _codes.Length; i++)
            {
                var (pair, _) = _codes[i];
                for (int j = k;j<=126;j++) {
                    if (!usedSymbols[j-33])
                    {
                        _codes[i] = (pair, (char)j);
                        usedSymbols[j] = true;
                        k = j+1;

                        break;
                    }
                }
            }

            string result = _input;
            for (int i = 0; i < _codes.Length; i++)
            {
                var (pair, code) = _codes[i];
                int index = 0;
                while ((index = result.IndexOf(pair, index)) != -1)
                {
                    result = result.Remove(index, 2);
                    result = result.Insert(index, code.ToString());
                    index += 1;
                }
            }

            _output = result;

        }

        public override string ToString() => _output;
    }
}


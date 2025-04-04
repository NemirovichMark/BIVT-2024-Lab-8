﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3: Purple
    {
        private string _output;
        private (string, char)[] _codes;
        public string Output => _output;

        public (string, char)[] Codes
        {
            get
            {
                if (_codes == null)
                    return null;

                return ((string, char)[])_codes.Clone();
            }
       
        }

        public Purple_3(string input) : base(input)
        {
            _output = default(string);
            _codes = default((string, char)[]);
        }
        public override void Review()
        {
            string _input = Input;
            if (_input == null)
                return;

            CompressText(_input);
        }

        private void CompressText(string text)
        {
            const int maxReplacements = 5;

            char[] compressedArr = text.ToCharArray();

            var topPairs = (
                from i in Enumerable.Range(0, text.Length - 1)
                let pair = text.Substring(i, 2)
                where char.IsLetter(pair[0]) && char.IsLetter(pair[1])
                group pair by pair into g
                orderby g.Count() descending, text.IndexOf(g.Key) ascending
                select g.Key
            ).Take(maxReplacements).ToArray();

            
            bool[] check = new bool[94];
            foreach (char c in text)
            {
                if (c <= 126 && c >= 32)
                {
                    check[c - 32] = true;
                }
            }

            (string, char)[] replacementCodes = new (string, char)[maxReplacements];

            for (int i = 32, k = 0; i <= 126 && k < topPairs.Length; i++)
            {
                if (!check[i - 32])
                {
                    replacementCodes[k] = (topPairs[k], (char)i);
                    k++;
                }
            }

            for (int j = 0; j < replacementCodes.Length; j++)
            {

                for (int i = 0; i < compressedArr.Length - 1; i++)
                {
                    string pair = new string(new char[] { compressedArr[i], compressedArr[i + 1] });
                    if (pair == topPairs[j])
                    {
                        compressedArr[i] = replacementCodes[j].Item2;
                        compressedArr[i + 1] = '\0';
                    }
                }
            }



            _output = new string(compressedArr).Replace("\0", "");

            _codes = replacementCodes;
        }

        
        public override string ToString() { return _output; }
    }
}

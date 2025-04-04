using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2: Purple
    {
        private string[] _output;
        private string _toString;
        public string[] Output{
            get {
                if (_output == null)
                    return null;
                string[] outputCopy = new string[_output.Length];
                Array.Copy(_output, outputCopy, _output.Length);
                return _output;
            }
        }

        public Purple_2(string input) : base(input) {
            if (input == null)
                return;
            _toString = default(string);
            _output = default(string[]);
        }

        public override void Review()
        {
            string[] words = Input.Split(' ').Where(x => x != "").ToArray();

            int lineIdx = 0, tempCnt = 0, spaces, add;
            int wordCnt = 0;
            string tempString;

            _output = new string[21];

            for (int i = 0; i < words.Length; i++)
            {
                if (tempCnt + words[i].Length + wordCnt > 50)
                {
                    if (wordCnt == 1)
                    {
                        _output[lineIdx++] = words[i];
                        tempCnt = words[i].Length;
                        wordCnt = 1;
                        continue;
                    }
                    tempString = "";
                    spaces = (50 - tempCnt) / (wordCnt - 1);
                    add = (50 - tempCnt) % (wordCnt - 1);
                    for (int j = i - wordCnt; j < i; j++)
                    {
                        tempString += words[j];
                        if (j != i - 1)
                        {
                            for (int k = 0; k < spaces; k++)
                            {
                                tempString += ' ';
                            }
                            if (add > 0)
                            {
                                tempString += ' ';
                                add--;
                            }
                        }
                        
                    }
                    _output[lineIdx++] = tempString ;
                    tempCnt = words[i].Length;
                    wordCnt = 1;
                }
                else
                {
                    tempCnt += words[i].Length;
                    wordCnt++;
                }
            }
            if (wordCnt == 1)
            {
                _output[lineIdx++] = words[words.Length - 1];
            }
            else
            {
                tempString = "";
                spaces = (50 - tempCnt) / (wordCnt - 1);
                add = (50 - tempCnt) % (wordCnt - 1);
                for (int j = words.Length - wordCnt; j < words.Length; j++)
                {
                    tempString += words[j];
                    if (j != words.Length - 1)
                    {
                        for (int k = 0; k < spaces; k++)
                        {
                            tempString += ' ';
                        }
                        if (add > 0)
                        {
                            tempString += ' ';
                            add--;
                        }
                    }
                }
                _output[lineIdx++] = tempString;


            }
            Array.Resize(ref _output, lineIdx);
            _toString = String.Join("\n", _output);
        }

        public override string ToString() {
            return _toString; 
        }
    }
}

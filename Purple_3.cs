using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        private string _output;
        private (string, char)[] _codes;

        public string Output => _output;
        public (string, char)[] Codes
        {
            get
            {
                if(_codes == null)
                {
                    return null;
                }
                var newcode = new (string, char)[5];
                Array.Copy(_codes, newcode, _codes.Length);
                return newcode;
            }
        }


        public Purple_3(string input) : base(input) {
            _codes = new (string, char)[0];
        }

        private void Add(string pair, char c)
        {
            Array.Resize(ref _codes, _codes.Length + 1);
            _codes[^1] = (pair, c);
        }

        private bool[] SetCodeAsUsed(string s)
        {
            bool[] range = new bool[126 - 32 + 1];
            foreach(char c in s)
            {
                if(c >= 32 &&  c <= 126)
                {
                    range[c - 32] = true;
                }
            }
            return range;
        }

        public override void Review()
        {
            if (Input == null)
            {
                return;
            }

            bool[] ASCIIrange = SetCodeAsUsed(Input);
            string[] pairs = new string[Input.Length-1];

            for (int i = 0; i < Input.Length - 1; ++i)
            {
                
                pairs[i] = String.Concat(Input[i], Input[i + 1]);
            }
            pairs = pairs.Where(p => p.All(char.IsLetter)).ToArray();
            pairs = pairs.GroupBy(p => p).OrderByDescending(t => t.Count()).Take(5).Select(t => t.Key).ToArray();

           
            int lastindex = 0;
            char code = default(char);
            for(int i = 0; i < pairs.Length; ++i)
            {
                for(int j = lastindex+1; j < ASCIIrange.Length; ++j)
                {
                    if (ASCIIrange[j] == false)
                    {
                        lastindex = j;
                        code = (char)(32 + j);
                        ASCIIrange[j] = true;
                        break;
                    }
                }
                Add(pairs[i], code);
            }


            var result = new StringBuilder(Input);
            foreach (var el in _codes)
            {
                result.Replace(el.Item1, el.Item2.ToString());
            }


            _output = result.ToString();

        }

        public override string ToString()
        {
            return _output;
        }

    }
}

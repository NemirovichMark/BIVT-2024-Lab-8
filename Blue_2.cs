using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_2 :Blue
    {
        private string _output;
        private string _posled;
        public string Output => _output;
        public Blue_2(string input,string posled) : base(input) 
        { 
            _posled = posled;
            _output = _input;        
        }

        public override void Review()
        {
            if (string.IsNullOrWhiteSpace(_input)  || string.IsNullOrEmpty(_posled)|| string.IsNullOrEmpty(_input))
            {
                _output = null;
                return;
            }

            //char[] prep = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            // var text = _input.Split(' ');
            //if (_posled == null || _output == null || _posled == "" || _output == "") return;

            //string[] words = _output.Split(' ');
            //var res = new StringBuilder();
            //foreach (string word in words)
            //{
            //    if (!word.ToLower().Contains(_posled.ToLower()))
            //    {
            //        if (res.Length > 0)
            //        {
            //            res.Append(' ');
            //        }
            //        res.Append(word);
            //    }
            //    else if (word.Length > 0 &&
            //             !(char.IsLetter(word[word.Length -1]) || word[word.Length - 1] == '`' || word[word.Length - 1] == '-'))
            //    {
            //        //if (res.Length > 0)
            //        //{
            //        //    res.Length--;
            //        //}
            //        res.Append(word[word.Length - 1]);
            //    }
            //}
            //_output = res.ToString();
            string[] text = _output.Split(' ');
            string result = "";
            string separator = "";

            foreach (string word in text)
            {
                if (string.IsNullOrWhiteSpace(word) || string.IsNullOrEmpty(word)) continue;
                if (!word.ToLower().Contains(_posled.ToLower()))
                {
                    result += separator + word;
                    separator = " ";
                }
                else if (word.Length > 0 && !(char.IsLetter(word[word.Length - 1]) ))
                {
                    result +=  word[word.Length - 1];
                    separator = " ";
                }
            }

            _output = result;

            //int podhod = 0;
            //foreach (var word in text)
            //{
            //    if (string.IsNullOrWhiteSpace(word)) continue;
            //    if (!word.Contains(_posled)) podhod++;
            //    if (word.Contains(_posled) && (word.Contains('.') || word.Contains('!') || word.Contains('?') || word.Contains(',') || word.Contains(':') || word.Contains('\"') || word.Contains(';') || word.Contains('–') || word.Contains('(') || word.Contains(')') || word.Contains('[') || word.Contains(']') || word.Contains('{') || word.Contains('}') || word.Contains('/'))) podhod++;
            //}
            //int ind = 0;
            //string[] res = new string[podhod];
            //foreach (var word in text)
            //{
            //    if (!word.Contains(_posled)) res[ind++] = word;
            //    if (word.Contains(_posled) && (word.Contains('.') || word.Contains('!') || word.Contains('?') || word.Contains(',') || word.Contains(':') || word.Contains('\"') || word.Contains(';') || word.Contains('–') || word.Contains('(') || word.Contains(')') || word.Contains('[') || word.Contains(']') || word.Contains('{') || word.Contains('}') || word.Contains('/'))) res[ind++] =$"{word[word.Length]}";
            //}
            //_output = string.Join(" ", res);

        }
        
        
        public override string ToString()
        {
            //if (string.IsNullOrEmpty(_output)) return null;
            return _output;
        }
    }
}

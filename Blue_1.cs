using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_1: Blue
    {
        private string[] _output;
        public string[] Output => _output;
        public Blue_1(string input) : base(input)
        {
            _output = null;
        }
        
       
        public override void Review()
        {
            if (_input == null) return;
            string[] text= _input.Split(' ');
            string[] temp= new string [text.Length];
            int countl= 0;
            string line = "";
            foreach (string word in text)
            {
                if (string.IsNullOrWhiteSpace(word) || string.IsNullOrEmpty(word)) continue;
                if (line.Length==0) line=word;

                else if (line.Length + word.Length + 1 <= 50)
                {
                    line += " " + word ;
                }
                else
                {
                    temp[countl++] = line;
                    line = word;
                }
            }
            if (!string.IsNullOrEmpty(line))
            {
                temp[countl++]=line;
            }
            _output = new string[countl];
            Array.Copy(temp, _output, countl);


        }
        public override string ToString() 
        {
            if (_output == null) return null;
            string ans = "";
            for(int i=0; i < _output.Length; i++)
            {
                ans += $"{_output[i]}\n";
            }
            if (string.IsNullOrEmpty(ans)) return null;
            ans=ans.Remove(ans.Length - 1, 1);
            return ans;
        
        }
    }
}

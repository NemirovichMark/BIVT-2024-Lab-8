using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_4:Blue
    {
        private int _output;
        public int Output => _output;

        public Blue_4(string input) : base (input)
        {
            _output = 0; 
        }
        public override void Review() 
        {
            if (string.IsNullOrEmpty(_input))
            {
                return;
            }
            //char[] prep = { '.', '!', '?', ',', ':', '\"', ';', '(', ')', '[', ']', '{', '}', '/' };
            
            int sign;
            int startind = 0;
            var text = _input.Split(' ',',','/');
            foreach(string word in text)
            {
                if (string.IsNullOrWhiteSpace(word) || string.IsNullOrEmpty(word)) continue;
                if (char.IsDigit(word[0])|| ( word.Length>1 && word[0] =='-' && char.IsDigit(word[1]))  )
                {

                    if (word[0] == '-')
                    {
                         sign = -1;
                        startind = 1;
                    }
                    else
                    {
                         sign = 1;
                    }
                    int result = 0;
                    foreach (char c in word)
                    {
                        if(char.IsDigit(c))
                        {
                            result = result * 10 + (c - '0');
                        }
                        
                    }
                    result *= sign;
                    _output+= result;
                }
                
            }
            

        }
        public override string ToString()
        {
             
            return $"{_output}";
        }

    }
}

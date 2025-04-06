using System;
using System.Linq;

namespace Lab_8{
    public abstract class Purple{
        private string _input;

        public string Input => _input;

        protected readonly char[] chars = {
            '.', '!', '?', ',', 
            ':', '\"', ';', '–', 
            '(', ')', '[', ']', 
            '{', '}', '/', ' ' 
        };

        public Purple(string input){
            _input = input;
        }

        protected bool isChar(char s){
            for (int i = 0; i < chars.Length; i++){
                if (chars[i] == s){
                    return true;
                }
            }
            return false;
        }

        public abstract void  Review();
    }
}
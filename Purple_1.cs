using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8 {
    public class Purple_1 : Purple
    {
        private string _output = "";
    
        public string Output => _output;
    
        public Purple_1(string input) : base(input) {}
    
        public override void Review() {
            if (Input == null) return;
            
            char[] punctuation = { '.', '!', '?', ',', ':', '"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            StringBuilder curWord = new StringBuilder();
            StringBuilder resString = new StringBuilder();
            
            foreach (char c in Input) {
                if (Array.IndexOf(punctuation, c) != -1 || char.IsWhiteSpace(c)) {
                    if (curWord.Length > 0) {
                        char[] wordChars = curWord.ToString().ToCharArray();
                        Array.Reverse(wordChars);
                        resString.Append(wordChars);
                        curWord.Clear();
                    }
                    resString.Append(c);
                }
                else curWord.Append(c);
            }
        
            if (curWord.Length > 0) {
                char[] wordChars = curWord.ToString().ToCharArray();
                Array.Reverse(wordChars);
                resString.Append(wordChars);
            }
        
            _output = resString.ToString();
        }

        public override string ToString() => Output;
    }
}

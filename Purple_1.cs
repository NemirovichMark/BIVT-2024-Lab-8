using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {

        public string Output { get; private set; }
        public Purple_1(string input) : base(input) { Output = default(string); } 


        public override void Review()
        {
            if (string.IsNullOrEmpty(Input)){
                Output = string.Empty;
                return;
            };

            var words = Input.Split(' ');
            var massive_of_words = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                massive_of_words[i] = Reversing(words[i]);
            }
            Output = string.Join(" ", massive_of_words);

        }
        private string Reversing(string word) {
            if (string.IsNullOrEmpty(word)) return word;

            int start = 0; int ending = word.Length - 1;
            char[] chars_of_word = word.ToCharArray();

            while (start < ending) {
                if (char.IsPunctuation(chars_of_word[start])) {
                    start++;
                    continue;
                }
                if (char.IsPunctuation(chars_of_word[ending])) {
                    ending--;
                    continue;
                }
                (chars_of_word[start], chars_of_word[ending]) = (chars_of_word[ending],chars_of_word[start]);
                start++; ending--;
            }
            return new string(chars_of_word);
        }
        public override string ToString()
        {
            return Output;
        }
    }
}

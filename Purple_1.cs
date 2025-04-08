using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private char[] not_letters;
        public string Output { get; private set; }
        public Purple_1(string input) : base(input) { Output = default(string); } 


        public override void Review()
        {
            if (string.IsNullOrEmpty(Input)){
                Output = string.Empty;
                return;
            };
            var not_letters = new char[]{' ','.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            string[] massive_of_text = Input.Split(not_letters);

            StringBuilder reversing_text = new StringBuilder(); int k = -1;

            foreach (string word in massive_of_text) { 
                if (Proverka_na_word(word)) {
                    var reversing_word = word.Reverse();
                    reversing_text.Append(reversing_word.ToArray());
                }
                else
                {
                    reversing_text.Append(word);
                }
                k += word.Length + 1;
                if (k < Input.Length)
                {
                    reversing_text.Append(Input[k]);
                }
                Output = reversing_text.ToString();
            }

    }
  

        
        public override string ToString()
        {
            return Output;
        }
    }
}

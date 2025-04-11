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
            if (string.IsNullOrEmpty(Input))
            {
                Output = string.Empty;
                return;
            }
            

            not_letters = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };

            string[] words_of_text = Input.Split(not_letters);
            int search_from = 0;

            foreach (var word in words_of_text)
            {
                int starting = Input.IndexOf(word, search_from);

                Output += Input.Substring(search_from, starting - search_from);

                bool checking = word.Any(c => char.IsDigit(c));
                if (checking)
                {
                    Output += word;
                }
                else
                {
                    char[] reversed = word.ToArray();
                    Array.Reverse(reversed);
                    Output += new string(reversed);
                }

                search_from = starting + word.Length;
            }

            Output += Input.Substring(search_from);  
        }

        

        public override string ToString()
        {
            return Output;
        }
    }
}

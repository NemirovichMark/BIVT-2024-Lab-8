using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private string _output;
        
        private static char[] punctuationMarks =
            { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };

        public string Output => _output;

        public Purple_1(string input) : base(input)
        {
        }

        public override void Review()
        {
            if (String.IsNullOrEmpty(Input))
            {
                _output = Input;
                return;
            }

            var words = Input.Split().Where(x => x.Length != 0).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];

                if (word.Any(Char.IsDigit) || word.Length == 1 && punctuationMarks.Contains(word[0])) continue;

                int startIndex = 0;
                int endIndex = word.Length;

                for (int j = 0; j < word.Length; j++)
                {
                    if (punctuationMarks.Contains(word[j])) startIndex++;
                    else break;
                }

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    if (punctuationMarks.Contains(word[j])) endIndex--;
                    else break;
                }

                var chars = word[startIndex..endIndex].ToCharArray();
                Array.Reverse(chars);
                word = word[..startIndex] + String.Join("", chars) + word[endIndex..];

                words[i] = word;
            }

            _output = String.Join(' ', words);
        }

        public override string ToString()
        {
            return Output;
        }
    }
}
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string[] _output;

        public string[] Output => (string[])_output?.Clone();

        public Purple_2(string input) : base(input)
        {
        }

        public override void Review()
        {
            if (Input == null) return;
            
            var words = Input.Split();
            var strings = new string[1][];
            strings[0] = new string[0];

            var lengths = new int[1];

            int cntWords = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (lengths[^1] + cntWords + words[i].Length <= 50)
                {
                    Array.Resize(ref strings[^1], strings[^1].Length + 1);
                    strings[^1][^1] = words[i];
                    lengths[^1] += words[i].Length;
                    cntWords++;
                }
                else
                {
                    Array.Resize(ref strings, strings.Length + 1);
                    strings[^1] = new string[0];
                    Array.Resize(ref strings[^1], strings[^1].Length + 1);
                    strings[^1][^1] = words[i];
                    Array.Resize(ref lengths, lengths.Length + 1);
                    
                    lengths[^1] = words[i].Length;
                    cntWords = 1;
                }
            }
            
            for (int i = 0; i < strings.Length; i++)
            {
                cntWords = strings[i].Length;
                int cntSpaces = cntWords - 1;

                int lengthSpaces = 50 - lengths[i];

                if (cntSpaces == 0) continue;
                
                int minSpaceLength = lengthSpaces / cntSpaces;
                int cntOneMoreSpace = lengthSpaces - minSpaceLength * cntSpaces;

                for (int j = 0; j < strings[i].Length - 1; j++)
                {
                    strings[i][j] += new string(' ', minSpaceLength);

                    if (j < cntOneMoreSpace) strings[i][j] += ' ';
                }
            }

            _output = strings.Select(x => String.Join("", x)).ToArray();
        }

        public override string ToString()
        {
            if (Output == null) return null;

            return String.Join('\n', Output);
        }
    }
}
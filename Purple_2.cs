using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8 {
    class Purple_2 : Purple
    {
        private string[] _output;

        public string[] Output
        {
            get {
                if (_output == null) return null;
                string[] output = new string[_output.Length];
                Array.Copy(_output, output, _output.Length);
                return output;
            }
        }

        public Purple_2(string input) : base(input) {}

        public override void Review()
        {
            if (Input == null || Input.Length > 1000) return;
            
            // string text = Input.Length > 1000 ? Input.Substring(0, 1000) : Input;

            const int maxLength = 50;

            // будем оценивать как худший случай => максимальное кол-во строк равно количеству слов
            // при 1000 символах - ~200 английских или ~170 русских слов
            string[] words = Input.Split(' ');
            string[] lines = new string[words.Length];
            
            int wordInd = 0;
            int lineCnt = 0;

            StringBuilder line = new StringBuilder();

            while (wordInd < words.Length) {
                string word = words[wordInd];
                // по условию задачи слово разрывать нельзя, так что если оно само по себе больше >50, то пропускаем?
                if (word.Length > maxLength) {
                    wordInd++;
                    continue;
                }
                if (line.Length + word.Length + (line.Length > 0 ? 1 : 0) <= maxLength) { 
                    if (line.Length > 0) line.Append(' ');
                    line.Append(word);
                    wordInd++;
                }
                else {
                    if (line.Length > 0) {
                        lines[lineCnt++] = FormatSpaces(line.ToString().Split(' '), maxLength);
                        line.Clear();
                    }
                }
            }
            
            if (line.Length > 0) lines[lineCnt++] = FormatSpaces(line.ToString().Split(' '), maxLength);
            
            _output = new string[lineCnt];
            Array.Copy(lines, _output, lineCnt);
        }

        private string FormatSpaces(string[] words, int lineLength)
        {
            if (words.Length == 1) return words[0];
            
            int lenRem = lineLength - words.Sum(w => w.Length);;
            int posCnt = words.Length - 1;
            int spaces = lenRem / posCnt;
            int extraSpaces = lenRem % posCnt;

            StringBuilder formattedLine = new StringBuilder();
            formattedLine.Append(words[0]);

            for (int i = 1; i < words.Length; i++) {
                int spacesToInsert = spaces + (i <= extraSpaces ? 1 : 0);
                formattedLine.Append(new string(' ', spacesToInsert));
                formattedLine.Append(words[i]);
            }
            return formattedLine.ToString();
        }

        public override string ToString() => string.Join("\n", _output);
    }
}
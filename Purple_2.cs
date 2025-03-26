using System.Text;

namespace Lab_8
{
    public class Purple_2 : Purple{
        
        private string[] _output;

        public string[] Output => (string[]) _output.Clone();

        public Purple_2(string input): base(input){}

        public override void Review(){
            if (Input == null) return;

            string[] words = Input.Split([' '], StringSplitOptions.RemoveEmptyEntries);

            int maxLineLength = 50;
            int currentLineLength = 0;
            int lineCount = 1;

            for (int i = 0; i < words.Length; i++){
                int wordLength = words[i].Length;
                if (currentLineLength > 0) wordLength++;
                
                if (currentLineLength + wordLength <= maxLineLength) currentLineLength += wordLength;
                else
                {
                    lineCount++;
                    currentLineLength = words[i].Length;
                }
            }

            _output = new string[lineCount];
            int currentWordIndex = 0;
            
            for (int lineIndex = 0; lineIndex < lineCount; lineIndex++){
                int wordsInLineCount = 0;
                currentLineLength = 0;
                
                for (int i = currentWordIndex; i < words.Length; i++){
                    int wordLength = words[i].Length;

                    if (currentLineLength > 0) wordLength++;
                    
                    if (currentLineLength + wordLength <= maxLineLength){
                        currentLineLength += wordLength;
                        wordsInLineCount++;
                    }
                    else break;
                }

                string[] lineWords = new string[wordsInLineCount];
                Array.Copy(words, currentWordIndex, lineWords, 0, wordsInLineCount);
                currentWordIndex += wordsInLineCount;

                if (lineWords.Length == 1) _output[lineIndex] = lineWords[0];
                else{
                    int totalLength = lineWords.Sum(w => w.Length) + (lineWords.Length - 1);
                    int spacesToAdd = maxLineLength - totalLength;
                    int baseSpaces = 1 + spacesToAdd / (lineWords.Length - 1);
                    int extraSpaces = spacesToAdd % (lineWords.Length - 1);

                    StringBuilder sb = new StringBuilder(lineWords[0]);
                    for (int i = 1; i < lineWords.Length; i++){
                        int spaces = baseSpaces + (i <= extraSpaces ? 1 : 0);
                        sb.Append(new string(' ', spaces));
                        sb.Append(lineWords[i]);
                    }
                    
                    _output[lineIndex] = sb.ToString();
                }
            }
        }
        public override string ToString() => string.Join("\n", _output);   
    }
}
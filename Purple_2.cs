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
            int lineCount = 0;

            for (int i = 0; i < words.Length; i++){
                if (currentLineLength + words[i].Length + (currentLineLength > 0 ? 1 : 0) <= maxLineLength) {
                    currentLineLength += words[i].Length + (currentLineLength > 0 ? 1 : 0);
                }
                else{
                    lineCount++;
                    currentLineLength = words[i].Length;
                }
            }
            lineCount++;

            _output = new string[lineCount];

            int currentWordIndex = 0;
            currentLineLength = 0;

            for (int i = 0; i < lineCount; i++){
                string currentLine = string.Empty;

                while (currentWordIndex < words.Length && currentLine.Length + words[currentWordIndex].Length + (currentLine.Length > 0 ? 1 : 0) <= maxLineLength){
                    if (currentLine.Length > 0)
                        currentLine += " ";
                    currentLine += words[currentWordIndex];
                    currentWordIndex++;
                }

                _output[i] = currentLine;
            }

            _output = _output.Select(line =>
            {
                var wordsInLine = line.Split(' ');

                if (line.Length < maxLineLength){
                    int spacesToAdd = maxLineLength - line.Length;
                    if (wordsInLine.Length > 1){
                        int spaceCount = wordsInLine.Length - 1;
                        int spacesPerGap = spacesToAdd / spaceCount;
                        int extraSpaces = spacesToAdd % spaceCount;

                        for (int i = 0; i < extraSpaces; i++) wordsInLine[i] += " ";

                        return string.Join(" ", wordsInLine);
                    }
                    else return line + new string(' ', spacesToAdd);
                }
                return line; 
            }).ToArray();
        }
        public override string ToString() => string.Join("\n", _output);   
    }
}
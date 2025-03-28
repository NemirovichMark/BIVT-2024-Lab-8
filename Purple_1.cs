namespace Lab_8
{
    public class Purple_1 : Purple{
        private string _output;
        private string copy;

        public string Output => _output;

        public Purple_1(string input) : base(input) {copy = Input;}

        public override void Review(){
            if (copy == null) return;

            _output = string.Empty;
            string[] words = copy.Split(punctuation_marks);
            int last = 0;

            foreach (string word in words){
                int start = copy.IndexOf(word, last);
                _output +=  copy.Substring(last, start - last);

                if (word.Any(c => char.IsDigit(c))) _output += word;

                else{
                    char[] reversed = word.ToArray();
                    Array.Reverse(reversed);
                    _output += new string(reversed);
                }

                last = start + word.Length;
            }
            _output += copy.Substring(last);
            copy = (string) _output.Clone();
        }
        public override string ToString() { return _output; }
    }
}
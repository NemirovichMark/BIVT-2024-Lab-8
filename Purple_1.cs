namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private string _output;


        public string Output => _output;

        public Purple_1(string input): base(input){}

        public override void Review(){
            string[] words = Input.Split(punctuation_marks);
            int last = 0;
            
            foreach (string word in words){
                int start = Input.IndexOf(word, last);
                _output += Input.Substring(last, start - last);

                char[] reversed = word.ToArray();
                Array.Reverse(reversed);
                _output += new string(reversed);

                last = start + word.Length;
            }
            _output += Input.Substring(last);
        }
        public override string ToString() {return _output;}
    }
}
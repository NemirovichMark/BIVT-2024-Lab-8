namespace Lab_8{
    public abstract class Purple{
        private string _input;

        public string Input => _input;

        protected readonly char[] punctuation_marks = {'.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/'};

        public Purple(string input){
            if (input == null) return;
            _input = input;
        }
        public abstract void Review();

    }
}
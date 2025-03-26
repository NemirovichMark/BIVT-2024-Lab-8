using System.Text;

namespace Lab_8 {
    public class Purple_4 : Purple{
        private string _output;
        private (string, char)[] _codes;

        public string Output => _output;

        public Purple_4(string input, (string, char)[] codes) : base(input){
            _codes = codes;
    }

        public override void Review(){
            StringBuilder decoded = new StringBuilder(Input);

            foreach (var code in _codes){
                decoded.Replace(code.Item2.ToString(), code.Item1);
            }

            _output = decoded.ToString();
    }
         public override string ToString() => Output;
    }
}
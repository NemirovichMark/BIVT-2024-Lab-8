using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8 {
    class Purple_4 : Purple
    {
        private string _output = "";
        private (string, char)[] _codes;
    
        public string Output => _output;
    
        public Purple_4(string input, (string, char)[] codes) : base(input) => _codes = codes;
    
        public override void Review()
        {
            if (Input == null || _codes == null) return;
            StringBuilder output = new StringBuilder(Input);
            foreach ((string, char) code in _codes) output = output.Replace(code.Item2.ToString(), code.Item1);
            _output = output.ToString();
        }

        public override string ToString() => Output;
    }
}
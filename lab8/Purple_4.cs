using System;
using System.Linq;

namespace Lab_8{
    public class Purple_4 : Purple{
        private string _output;
        private (string, char)[] _codes;

        public string Output => _output;
        public (string, char)[] Codes => _codes;
        // public (string, char)[] Codes{
        //     get{
        //         if (_codes == null){
        //             return null;
        //         }

        //         (string, char)[] copy = new (string, char)[_codes.Length];
        //         Array.Copy(_codes, copy, _codes.Length);
        //         return copy;
        //     }
        // }

        public Purple_4(string input, (string, char)[] codes) : base(input) { 
            _output = null;
            _codes = codes;
        }

        public override void Review()
        {
            string input = Input; //Изначальная строка
            //char[] chars = Input.ToCharArray();
            for (int i = 0; i < _codes.Length; i++){
                string ans = "";
                for (int j = 0; j < input.Length; j++){
                    if (input[j] == _codes[i].Item2){
                        ans += _codes[i].Item1;
                    }
                    else{
                        ans += input[j];
                    }
                }
                input = ans;//Строка с изменнеными нужными элементами
            }
            _output = input;
            
        }
        public override string ToString() { return _output; }
    }
}
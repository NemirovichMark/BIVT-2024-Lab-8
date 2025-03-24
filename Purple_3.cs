using System.Text;

namespace Lab_8
{
    public class Purple_3 : Purple{
        private string _output;
        private (string, char)[] _codes = [];
    
        public string Output => _output;
        public (string, char)[] Codes => _codes;
    
        public Purple_3(string input) : base(input) {}

        public override void Review(){
            if (Input == null) return;

            (string, int)[] sequences = new (string, int)[Input.Length - 1];

            for (int i = 0; i < Input.Length - 1; i++){
                string pair = Input.Substring(i, 2);

                bool found = false;
                for (int j = 0; j < i; j++){
                    if (sequences[j].Item1 == pair){
                        sequences[j] = (pair, sequences[j].Item2 + 1);
                        found = true;
                        break;
                    }
                }
                if (!found) sequences[i] = (pair, 1);
            }

            var top5Sequences = sequences.OrderByDescending(s => s.Item2)
                                        .ThenBy(s => Input.IndexOf(s.Item1))
                                        .Take(5)
                                        .ToArray();

            _codes = new (string, char)[top5Sequences.Length];
            char currentCode = (char)32; 
            char[] usedCodes = new char[95]; 

            for (int i = 0; i < top5Sequences.Length; i++){
                var seq = top5Sequences[i];

                while (usedCodes[currentCode - 32] != 0 && currentCode <= 126) currentCode++;

                if (currentCode <= 126){
                    _codes[i] = (seq.Item1, currentCode);
                    usedCodes[currentCode - 32] = currentCode;
                }
            }

            StringBuilder encryptedText = new StringBuilder(Input);

            foreach (var seq in _codes) encryptedText.Replace(seq.Item1, seq.Item2.ToString());

            _output = encryptedText.ToString();
        }

        public override string ToString() => Output;
    }
}
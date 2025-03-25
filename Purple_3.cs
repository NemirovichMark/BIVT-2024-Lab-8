

using System.Text;

namespace Lab_8
{
    public class Purple_3 : Purple{
        private string _output;
        private (string, char)[] _codes = []; 

        public string Output => _output;
        public (string, char)[] Codes => _codes;

        public Purple_3(string input) : base(input) { }

        public override void Review(){
            if (Input == null) return;

            string[] allPairs = new string[Input.Length - 1];
            int[] pairCounts = new int[Input.Length - 1];
            int uniquePairsCount = 0;

            for (int i = 0; i < Input.Length - 1; i++){
                string pair = Input.Substring(i, 2);
                if (pair.Contains(" ")) continue;

                bool found = false;
                for (int j = 0; j < uniquePairsCount; j++){
                    if (allPairs[j] == pair){
                        pairCounts[j]++;
                        found = true;
                        break;
                    }
                }

                if (!found){
                    allPairs[uniquePairsCount] = pair;
                    pairCounts[uniquePairsCount] = 1;
                    uniquePairsCount++;
                }
            }

            for (int i = 0; i < uniquePairsCount - 1; i++){
                for (int j = 0; j < uniquePairsCount - i - 1; j++){
                    bool swap = false;
                    if (pairCounts[j] < pairCounts[j + 1]){
                        swap = true;
                    }
                    else if (pairCounts[j] == pairCounts[j + 1]){
                        if (Input.IndexOf(allPairs[j]) > Input.IndexOf(allPairs[j + 1])){
                            swap = true;
                        }
                    }

                    if (swap){
                        string tempPair = allPairs[j];
                        allPairs[j] = allPairs[j + 1];
                        allPairs[j + 1] = tempPair;

                        int tempCount = pairCounts[j];
                        pairCounts[j] = pairCounts[j + 1];
                        pairCounts[j + 1] = tempCount;
                    }
                }
            }
            int topPairsCount = Math.Min(5, uniquePairsCount);
            string[] topPairs = new string[topPairsCount];
            for (int i = 0; i < topPairsCount; i++) topPairs[i] = allPairs[i];

            char[] availableCodes = new char[5];
            int availableCodesCount = 0;

            for (char c = (char)32; c <= 126 && availableCodesCount < 5; c++){
                bool found = false;
                for (int i = 0; i < Input.Length; i++){
                    if (Input[i] == c){
                        found = true;
                        break;
                    }
                }

                if (!found){
                    availableCodes[availableCodesCount] = c;
                    availableCodesCount++;
                }
            }

            _codes = new (string, char)[Math.Min(topPairsCount, availableCodesCount)];

            for (int i = 0; i < _codes.Length; i++)  _codes[i] = (topPairs[i], availableCodes[i]);

            var result = new StringBuilder(Input);
            foreach (var (pair, code) in _codes) result = result.Replace(pair, code.ToString());

            _output = result.ToString();
        }
    public override string ToString() => Output;
    }
}
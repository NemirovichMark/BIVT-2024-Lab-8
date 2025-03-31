using System;
using System.Linq;

namespace Lab_8{
    public class Purple_3 : Purple{
        private string _output;
        private string[] _unique;
        private int[] _counts;
        private char[] _codes;

        public string Output => _output;
        public (string, char)[] Codes
        {
            get
            {
                var result = new (string, char)[Math.Min(5, _unique.Length)];//учитывать что может использоваться менее чем 5 симовлов
                for (int i = 0; i < result.Length; i++)
                    result[i] = (_unique[i], _codes[i]);
                return result;
            }
        }

        public Purple_3(string input) : base(input) { 
            _output = input;
            _unique = new string[0];
            _codes = new char[0];
            _counts = new int[0];
        }

        public override void Review()
        {
            char[] chars = Input.ToCharArray();

            //string[] _unique = new string[0];
            bool[] usedChar = new bool[256];

            for (int i = 0; i < chars.Length-1; i++){
                if (isChar(chars[i]) || isChar(chars[i+1])){//проверяем можем ли мы его менять
                    continue;
                }
                //chars[i] автоматически переводится в аски код и на этой позиции отмечается флаг 
                if (chars[i] >= 0 && chars[i] < 256)
                    usedChar[chars[i]] = true;
                
                if (chars[i+1] >= 0 && chars[i+1] < 256)
                    usedChar[chars[i+1]] = true;

                // usedChar[chars[i]] = true; //
                // usedChar[chars[i+1]] = true;

                //считаем сколько раз встерчаются разные уникальные пары
                bool found = false;
                for (int j = 0; j < _unique.Length; j++){
                    if ($"{chars[i].ToString()}{chars[i+1].ToString()}" == _unique[j]){
                        found = true;
                        _counts[j] += 1;
                    }
                }
                if (!found){
                    Array.Resize(ref _unique, _unique.Length+1);
                    _unique[_unique.Length-1] = $"{chars[i].ToString()}{chars[i+1].ToString()}";

                    Array.Resize(ref _counts, _counts.Length+1);
                    _counts[_counts.Length-1] = 1;
                }
            }

            // for (int i = 0; i < _unique.Length; i++){
            //     System.Console.WriteLine($"{_unique[i]} - {_counts[i]}");
            // }

            // System.Console.WriteLine();

            //сортировка
            for (int i = 1; i < _counts.Length; i++){
                int k = i, j = k - 1;
                while (j >= 0){
                    if (_counts[j] < _counts[k]){

                    int tmp = _counts[j];
                    _counts[j] = _counts[k];
                    _counts[k] = tmp;

                    string tmpChar = _unique[j];
                    _unique[j] = _unique[k];
                    _unique[k] = tmpChar;
                    }
                    k = j;
                    j--;
                }
            }

            // for (int i = 0; i < _unique.Length; i++){
            //     System.Console.WriteLine($"{_unique[i]} - {_counts[i]}");
            // }
            
            //оставляем только 5 комбинаций
            int Count = Math.Min(5, _unique.Length); 
            Array.Resize(ref _unique, Count);
            Array.Resize(ref _counts, Count);

            // System.Console.WriteLine();
            // for (int i = 0; i < _unique.Length; i++){
            //     System.Console.WriteLine($"{_unique[i]} - {_counts[i]}");
            // }

            _codes = new char[Count];
            int Index = 0;
            for (char c = (char)33; c <= 126 && Index < Count; c++){//собираем все коды которые можем использвоать
                if (!usedChar[c]){
                    _codes[Index++] = c;
                }
            }

            // foreach (var i in _codes){
            //     System.Console.WriteLine(i);
            // }

            //Сделать чтобы в слове заменялась самая частая комбинация а не первая попавшая

            
            // for (int i = 0; i < chars.Length; i++){//проходим по всем символам
            //     bool changed = false;
            //     if (i+1 >= chars.Length){ //проверка
            //         break;
            //     }

            //     for (int j = 0; j < _unique.Length; j++){//проверяем будем ли менять символ
            //         if ($"{chars[i]}{chars[i+1]}" == _unique[j]){
            //             ans += _codes[j];
            //             i++;
            //             changed = true;
            //             break;
            //         }
            //     }
            //     if (!changed){//если ничего не меняли добавляем просто букву
            //         ans += chars[i];
            //     }
            // }

            // string input = _output;
            // System.Console.WriteLine(input);
            // for (int i = 0; i < _unique.Length; i++){
            //     string ans = "";
            //     for (int j = 0; j < input.Length; j++){
            //         // System.Console.WriteLine($"{input[j]} - {_codes[i]}");
            //     }
            //     System.Console.WriteLine(input);
            // }
            
            string input = _output;
            //System.Console.WriteLine(input);
            for (int i = 0; i < _unique.Length; i++){
                string ans = "";
                for (int j = 0; j < input.Length; j++){
                    bool changed = false;
                    if (j + 1 >= input.Length){
                        ans += input[j];
                        continue;
                    }

                    if ($"{input[j]}{input[j+1]}" == _unique[i]){
                        ans += _codes[i];
                        j++;
                    }
                    else{
                        ans += input[j];
                    }
                    // if ($"{input[j]}{input[j+1]}" == _unique[i]){
                    //     ans += _codes[i];
                    //     j++;
                    //     changed = true;
                    //     break;
                    // }
                    
                    // if (!changed){//если ничего не меняли добавляем просто букву
                    // ans += input[j];
                    // }
                }            
                input = ans;
                // System.Console.WriteLine(input);
            }
            
            _output = input;
            //System.Console.WriteLine(input);
        }
        public override string ToString() { return _output; }
    }
}
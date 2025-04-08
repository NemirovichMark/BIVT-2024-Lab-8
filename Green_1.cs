using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Green_1 : Green
    {
        private (char, double)[] _output;
        public (char, double)[] Output => _output;
        public Green_1(string input) : base(input) 
        {
            _output = null;
        }
        char[] letters = new char[33];

        char[] russianLetters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        public override void Review()
        {
            // Массив для подсчета количества каждой русской буквы
            int[] russianLetterCounts = new int[33];
            int totalAllLetters = 0; // Счетчик всех букв (включая не русские)
            
            // Подсчет букв в тексте
            string lowerInput = Input.ToLower();
            for (int i = 0; i < lowerInput.Length; i++)
            {
                char c = lowerInput[i];
                
                // Проверяем, является ли символ буквой (любой)
                if (char.IsLetter(c))
                {
                    totalAllLetters++;
                    
                    // Проверяем, является ли буква русской
                    for (int j = 0; j < russianLetters.Length; j++)
                    {
                        if (c == russianLetters[j])
                        {
                            russianLetterCounts[j]++;
                            break;
                        }
                    }
                }
            }
            // Создание массива результатов
            var result = new (char, double)[33];
            for (int i = 0; i < russianLetters.Length; i++)
            {
                // Используем totalAllLetters в знаменателе, как требуется
                double frequency = totalAllLetters > 0 ? (double)russianLetterCounts[i] / totalAllLetters : 0.0;
                result[i] = (russianLetters[i], frequency);
            }
            _output = result;
        }
        public override string ToString()
        {
            if (_output == null || _output.Length == 0)
                return "";
                
            string result = "";
            for (int i = 0; i < _output.Length; i++)
            {
                if(_output[i].Item2>0.0)
                {
                    result += $"{_output[i].Item1} - {_output[i].Item2:F4}";
                    if (i < _output.Length - 1)
                        result += "\n";
                }
            }
            
            return result;
        }
    }
}
using System;

namespace Lab_8
{
    public class Green_3 : Green
    {
        private string[] _output;
        private readonly string _sequence;
        
        public string[] Output => _output;
        
        public Green_3(string input, string sequence) : base(input)
        {
            _output = null;
            _sequence = sequence?.ToLower() ?? string.Empty; // Нормализуем искомую последовательность
        }

        public override void Review()
        {
            // Если sequence пустая или null, устанавливаем _output в null
            if (string.IsNullOrEmpty(_sequence))
            {
                _output = null;
                return;
            }

            // Если входная строка пустая, устанавливаем пустой массив
            if (string.IsNullOrEmpty(Input))
            {
                _output = Array.Empty<string>();
                return;
            }

            char[] delimiters = { 
                ' ', '.', '!', '?', ',', ':', '\"', ';',
                '–', '(', ')', '[', ']', '{', '}', '/' 
            };

            string[] words = Input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); // 2 параметр удаляет пустые строчки
            
            // Временный массив для хранения результатов (максимально возможный размер)
            string[] tempResults = new string[words.Length];
            int resultCount = 0;

            // Проверяем каждое слово
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();
                string lowerWord = currentWord.ToLower();
                
                // Проверяем содержит ли слово искомую последовательность
                if (lowerWord.Contains(_sequence))
                {
                    // Проверяем на дубликаты (без учета регистра)
                    bool isDuplicate = false;
                    for (int j = 0; j < resultCount; j++)
                    {
                        if (string.Equals(tempResults[j], currentWord, StringComparison.OrdinalIgnoreCase))
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    
                    // Если не дубликат, добавляем в результаты
                    if (!isDuplicate)
                    {
                        tempResults[resultCount] = currentWord;
                        resultCount++;
                    }
                }
            }

            // Создаем итоговый массив нужного размера
            _output = new string[resultCount];
            Array.Copy(tempResults, _output, resultCount);
        }

        public override string ToString()
        {
            return _output == null || _output.Length == 0 ? string.Empty : string.Join(Environment.NewLine, _output);
        }
    }
}
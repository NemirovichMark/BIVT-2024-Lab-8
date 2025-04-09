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
            // Приводим искомую последовательность к нижнему регистру при создании
            _sequence = sequence?.ToLower() ?? string.Empty;
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

            // Массив разделителей для разбиения текста на слова
            char[] delimiters = { 
                ' ', '.', '!', '?', ',', ':', '\"', ';',
                '–', '(', ')', '[', ']', '{', '}', '/' 
            };

            // Разбиваем строку на слова
            string[] tempWords = Input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Считаем сколько будет непустых слов после очистки
            int validWordCount = 0;
            foreach (string word in tempWords)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    validWordCount++;
                }
            }

            // Создаем массив нужного размера
            string[] words = new string[validWordCount];
            int index = 0;

            // Заполняем массив очищенными словами
            foreach (string word in tempWords)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    words[index] = word.Trim();
                    index++;
                }
            }
            
            
            // Временный массив для хранения результатов (максимально возможный размер)
            string[] tempResults = new string[words.Length];
            int resultCount = 0;

            // Проверяем каждое слово в тексте
            for (int i = 0; i < words.Length; i++)
            {
                // Приводим текущее слово к нижнему регистру для сравнения
                string lowerWord = words[i].ToLower();
                
                // Проверяем содержит ли слово искомую последовательность
                if (lowerWord.Contains(_sequence))
                {
                    // Проверяем на дубликаты (без учета регистра)
                    bool isDuplicate = false;
                    for (int j = 0; j < resultCount; j++)
                    {
                        // Сравниваем слова в нижнем регистре для корректного поиска дубликатов
                        if (tempResults[j].ToLower() == lowerWord)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    
                    // Если не дубликат, добавляем в результаты (в нижнем регистре)
                    if (!isDuplicate)
                    {
                        tempResults[resultCount] = lowerWord;
                        resultCount++;
                    }
                }
            }

            // Создаем итоговый массив нужного размера
            _output = new string[resultCount];
            // Копируем результаты из временного массива
            Array.Copy(tempResults, _output, resultCount);
        }

        public override string ToString()
        {
            // Если результатов нет, возвращаем пустую строку
            if (_output == null || _output.Length == 0)
                return string.Empty;
            
            // Объединяем результаты через перевод строки
            return string.Join(Environment.NewLine, _output);
        }
    }
}
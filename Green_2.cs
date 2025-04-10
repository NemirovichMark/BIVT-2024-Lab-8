using System;

namespace Lab_8
{
    public class Green_2 : Green
    {
        private char[] _output;
        public char[] Output => _output;

        public Green_2(string input) : base(input) 
        {
            _output = null;
        }

        public override void Review()
        {
            // Если входная строка пустая или null, устанавливаем _output в null
            if (string.IsNullOrEmpty(Input))
            {
                _output = null;
                return;
            }
            // Разделители слов
            char[] delimiters = { 
                ' ', '.', '!', '?', ',', ':', '\"', ';', 
                '–', '(', ')', '[', ']', '{', '}', '/' 
            };

            // Разбиваем текст на слова
            string[] words = Input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); // 2 параметр удаляет пустые строчки

            // Если после разделения нет слов, возвращаем пустой массив
            if (words.Length == 0)
            {
                _output = Array.Empty<char>();
                return;
            }
            
            // Массивы для хранения букв и их частот
            char[] letters = new char[words.Length];
            int[] counts = new int[words.Length];
            int uniqueLetters = 0;

            foreach (string word in words)
            {
                if (word.Length == 0) continue;

                char firstLetter = char.ToLower(word[0]);
                
                // Проверяем, что это буква (игнорируем цифры и прочие символы)
                if (!char.IsLetter(firstLetter)) continue;

                // Ищем букву в массиве
                bool found = false;
                for (int i = 0; i < uniqueLetters; i++)
                {
                    if (letters[i] == firstLetter)
                    {
                        counts[i]++;
                        found = true;
                        break;
                    }
                }

                // Если буква новая - добавляем
                if (!found)
                {
                    letters[uniqueLetters] = firstLetter;
                    counts[uniqueLetters] = 1;
                    uniqueLetters++;
                }
            }

            // Сортируем по частоте (убывание) и алфавиту
            for (int i = 0; i < uniqueLetters - 1; i++)
            {
                for (int j = i + 1; j < uniqueLetters; j++)
                {
                    if (counts[i] < counts[j] || 
                        (counts[i] == counts[j] && letters[i] > letters[j]))
                    {
                        // Меняем местами частоты
                        int tempCount = counts[i];
                        counts[i] = counts[j];
                        counts[j] = tempCount;
                        
                        // Меняем местами буквы
                        char tempLetter = letters[i];
                        letters[i] = letters[j];
                        letters[j] = tempLetter;
                    }
                }
            }

            // Формируем итоговый массив
            _output = new char[uniqueLetters];
            Array.Copy(letters, _output, uniqueLetters);
        }

        public override string ToString()
        {
            return _output == null || _output.Length == 0 ? string.Empty : string.Join(", ", _output);
        }
    }
}
using System;

namespace Lab_8
{
    public class Green_4 : Green
    {
        private string[] _output;
        public string[] Output => _output;

        public Green_4(string input) : base(input) 
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

            // Разделяем строку на фамилии и удаляем пустые элементы
            string[] tempWords = Input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

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
            string[] surnames = new string[validWordCount];
            int index = 0;

            // Заполняем массив очищенными словами
            foreach (string word in tempWords)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    surnames[index] = word.Trim();
                    index++;
                }
            }

            // Если нет фамилий, возвращаем пустой массив
            if (surnames.Length == 0)
            {
                _output = Array.Empty<string>();
                return;
            }

            // Очищаем от лишних пробелов
            for (int i = 0; i < surnames.Length; i++)
            {
                surnames[i] = surnames[i].Trim();
            }

            // Удаляем дубликаты (без учета регистра)
            int uniqueCount = 0;
            string[] uniqueSurnames = new string[surnames.Length];

            for (int i = 0; i < surnames.Length; i++)
            {
                bool isDuplicate = false;
                string current = surnames[i];
                
                // Проверяем, есть ли уже такая фамилия (без учета регистра)
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (string.Equals(current, uniqueSurnames[j], StringComparison.OrdinalIgnoreCase))
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    uniqueSurnames[uniqueCount] = current;
                    uniqueCount++;
                }
            }

            // Создаем массив нужного размера
            string[] result = new string[uniqueCount];
            Array.Copy(uniqueSurnames, result, uniqueCount);

            // Сортировка пузырьком
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - 1 - i; j++)
                {
                    if (CompareStrings(result[j].ToLower(), result[j + 1].ToLower()))
                    {
                        // Меняем местами
                        string temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            _output = result;
        }

        // Собственный метод сравнения строк
        private bool CompareStrings(string a, string b)
        {
            int minLength = a.Length < b.Length ? a.Length : b.Length;
            
            for (int i = 0; i < minLength; i++)
            {
                if (a[i] > b[i]) 
                    return true;
                if (a[i] < b[i])
                    return false;
            }
            
            return a.Length > b.Length;
        }

        public override string ToString()
        {
            return _output == null || _output.Length == 0 ? string.Empty : string.Join(Environment.NewLine, _output);
        }
    }
}
using System;

namespace Lab_8
{
    public class Green_4 : Green
    {
        private string[] _output;
        public string[] Output => _output;

        public Green_4(string input) : base(input) 
        {
            _output = Array.Empty<string>();
        }

        public override void Review()
        {
            // Разделяем строку на фамилии
            string[] surnames = Input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries); // 2 параметр удаляет пустые строчки

            // Очищаем от лишних пробелов
            for (int i = 0; i < surnames.Length; i++)
            {
                surnames[i] = surnames[i].Trim();
            }

            // Сортировка пузырьком
            for (int i = 0; i < surnames.Length - 1; i++)
            {
                for (int j = 0; j < surnames.Length - 1 - i; j++)
                {
                    if (CompareStrings(surnames[j].ToLower(), surnames[j + 1].ToLower()))
                    {
                        // Меняем местами
                        string temp = surnames[j];
                        surnames[j] = surnames[j + 1];
                        surnames[j + 1] = temp;
                    }
                }
            }

            _output = surnames;
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
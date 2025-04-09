using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lab_8
{
  public class Green_2 : Green
  {
    // Поля
    private (char, int)[] _output;
    private static readonly char[] _russianLetters;


    // Свойства
    public (char, int)[] Output => _output ?? Array.Empty<(char, int)>();

    // Статический конструктор
    static Green_2()
    {
      _russianLetters = new char[]
      {
                'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о',
                'п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'
      };
    }
    // Конструктор
    public Green_2(string input) : base(input)
    {
      _output = null;
    }

    // Методы
    private bool IsRussianLetter(char ch)
    {
      return (ch >= 'а' && ch <= 'я') || ch == 'ё';
    }

    // Методы
    public override void Review()
    {
      if (Input == null) return;

      string text = Input.ToLowerInvariant();
      string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

      var letterCounts = new int[_russianLetters.Length];

      foreach (string s in words)
      {
        for (int i = 0; i < _russianLetters.Length; i++)
        {
          if (s[0] == _russianLetters[i])
          {
            letterCounts[i]++;
            // totalLetters++;
            break;
          }
        }
      }
      _output = new (char, int)[_russianLetters.Length];
      for (int i = 0; i < _russianLetters.Length; i++)
      {
        _output[i] = (_russianLetters[i], letterCounts[i]);
      }

    }

    public override string ToString()
    {
      if (_output == null || _output.Length == 0)
        return string.Empty;

      return string.Join(", ",
    _output
        .Where(t => t.Item2 != 0)        // фильтруем: только те, у кого частота > 0
        .OrderBy(t => t.Item1)
        .Reverse()
        .OrderBy(t => t.Item2)           // сортируем по возрастанию
        .Reverse()                       // переворачиваем (в итоге — убывание)
        .Select(t => t.Item1)            // берём только символы
);

    }
  }
}

using System;
using System.Linq;
using System.Globalization;
namespace Lab_8
{
  public class Green_1 : Green
  {
    // Поля
    private (char, double)[] _output;
    private static readonly char[] _russianLetters;

    // Свойство
    public (char, double)[] Output => _output ?? Array.Empty<(char, double)>();

    // Статический конструктор
    static Green_1()
    {
      _russianLetters = new char[]
      {
            'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о',
            'п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'
      };
    }

    // Конструктор
    public Green_1(string input) : base(input)
    {
      _output = null;
    }

    // Методы
    private bool IsRussianLetter(char ch)
    {
      return _russianLetters.Contains(ch);
    }

    public override void Review()
    {
      if (Input == null) return;

      string text = Input.ToLowerInvariant();
      int totalLetters = 0;

      var letterCounts = new int[_russianLetters.Length];

      foreach (char c in text)
      {
        for (int i = 0; i < _russianLetters.Length; i++)
        {
          if (c == _russianLetters[i])
          {
            letterCounts[i]++;
            totalLetters++;
            break;
          }
        }
      }

      _output = new (char, double)[_russianLetters.Length];

      for (int i = 0; i < _russianLetters.Length; i++)
      {
        double freq = totalLetters > 0 ? Math.Round((double)letterCounts[i] / totalLetters, 4) : 0;
        _output[i] = (_russianLetters[i], freq);
      }
    }

    public override string ToString()
    {
      if (_output == null) return string.Empty;

      return string.Join(
          "\n",
          _output
              .OrderBy(t => t.Item1)
              .Select(t => $"{t.Item1} - {t.Item2.ToString("F4", CultureInfo.InvariantCulture)}")
      );
    }
  }

}

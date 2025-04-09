using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.Arm;

namespace Lab_8
{
  public class Green_4 : Green
  {
    // Поля
    private string[] _output;
    private static char[] _punctuation;

    // Свойства
    public string[] Output => _output ?? Array.Empty<string>();

    // Конструкторы
    public Green_4(string input) : base(input)
    {
      _output = null;
    }
    static Green_4()
    {
      _punctuation = ['.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/'];
    }

    // Методы
    public override void Review()
    {
      if (Input == null) return;
      string text = Input;
      string[] surnames = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
      for (int i = 0; i < surnames.Length; i++) {
        surnames[i] = new string(surnames[i].Where(c => !_punctuation.Contains(c)).ToArray());
      }
      for (int i = 0; i < surnames.Length; i++)
      {
        for (int j = i; j < surnames.Length; j++)
        {
          int len = surnames[i].Length < surnames[j].Length ? surnames[i].Length : surnames[j].Length;
          int flag = 1;
          for (int k = 0; k < len; k++)
          {
            if (surnames[i][k] == surnames[j][k])
            {
              continue;
            }
            else
            {
              if (surnames[i][k] < surnames[j][k])
              {
                flag = 0;
                break;
              }
              else
              {
                string tmp = surnames[i];
                surnames[i] = surnames[j];
                surnames[j] = tmp;
                flag = 0;
                break;
              }
            }
          }
          if (flag == 1)
          {
            if (surnames[i].Length > surnames[j].Length)
            {
              string tmp = surnames[i];
              surnames[i] = surnames[j];
              surnames[j] = tmp;
            }
          }
        }
      }
      _output = new string[surnames.Length];
      for (int i = 0; i < surnames.Length; i++)
      {
        _output[i] = surnames[i];
      }
    }
    public override string ToString() {
      if (_output == null || _output.Length == 0) return string.Empty;
          return string.Join("\n", _output);
    }
    //
  }
}
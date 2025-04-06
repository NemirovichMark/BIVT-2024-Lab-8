using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_3 : Blue
    {
        private (char, double)[] _output;
        private (char, int)[] _countLetter;
        private int _num;

        public (char, double)[] Output
        {
            get
            {
                if (_output == null) return null;

                (char, double)[] copy = new (char, double)[_output.Length];
                Array.Copy(_output, copy, _output.Length);
                return copy;
            }
        }
    
        public Blue_3(string input) : base(input)
        {
            _output = new (char, double)[0];
            _countLetter = new (char, int)[0];
            _num = 0;
        }

        private void AddCount(char c)
        {
            if (_countLetter == null) return;
            //if (!Char.IsLetter(c)) return;
            _num++; 
            for(int k = 0; k < _countLetter.Length; k++)
            {
                (char letter, int count) = _countLetter[k];
                if(c == letter)
                {
                    count++;
                    _countLetter[k] = (letter, count);
                    return;
                }
            }
            Array.Resize(ref _countLetter, _countLetter.Length + 1);
            _countLetter[_countLetter.Length - 1] = (c, 1);
        }
        private int NextWord(string str, int prev)
        {
            if (String.IsNullOrEmpty(str) || prev < 0) return -1;

            int index = prev+1;
            while (index < str.Length)
            {
                if ((Char.IsLetter(str[index]) || str[index] == '\'') || str[index] == '-') // предыдущее слово
                    index++;
                else break;
            }
            while (index < str.Length)
            {
                if (!Char.IsLetter(str[index])) // пространство между словами
                    index++;
                else break;
            }
            if (index == str.Length) return -1; // предыдущее слово - последнее в строке
            // index - начало искомого слова
             return index;
        }
        
        private void CountAllLetters()
        {
            if (String.IsNullOrEmpty(Input)) return;

            string inputToLower = Input.ToLower();
            int index = 0;
            if (!Char.IsLetter(inputToLower[index]))
                index = NextWord(inputToLower, index);
            if (index == -1) return;

            while (true)
            {
                char letter = inputToLower[index];
                AddCount(letter);

                index = NextWord(inputToLower, index);
                if(index == -1) return;
            }
        }
        private double LetterFrequency(int letterCounter)
        {
            double frequency = letterCounter / (double)_num;
            return 100 * frequency;
        }
        private void FindAllFrequency()
        {
            if (_countLetter == null) return;
            _output = new (char, double)[_countLetter.Length];

            int counter = 0;
            foreach((char letter, int letterNum) in _countLetter)
            {
                double freq = LetterFrequency(letterNum);
                _output[counter] = (letter,  freq);
                counter++;
            }
        }
        private void CountLetterSort()
        {
            if(_countLetter == null) return;

            int length = _countLetter.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    (char prev, int prevNum) = _countLetter[j];
                    (char next, int nextNum) = _countLetter[j+1];
                    if(nextNum > prevNum || (prevNum == nextNum && next < prev))
                    {
                        _countLetter[j] = (next, nextNum);
                        _countLetter[j + 1] = (prev, prevNum);
                    }
                }
            }
        }
        public override void Review()
        {
            CountAllLetters();
            CountLetterSort();
            FindAllFrequency();
        }
        private string FreqFormat(double freq)
        {
            string res = "";
            res += $"{Math.Round(freq, 4)}";
            if(freq == 100)
            {
                res += ",0000";
            }
            else if (freq < 10) 
            {
                if (res.Length == 1)
                    res += ",";
                while(res.Length < 6)
                    res += "0";
            }
            else
            {
                if (res.Length == 2)
                    res += ",";
                while (res.Length < 7)
                    res += "0";
            }
            return res;
        }
        public override string ToString()
        {
            // [letter][-][freq][\n] * _output.Length
            string str = "";
            foreach( (char letter, double freq) in _output)
                str += $"{letter} - {FreqFormat(freq)}\n";
            if(String.IsNullOrEmpty(str)) return str;
            str = str.Remove(str.Length - 1, 1);
            return str;
        }
    }
}

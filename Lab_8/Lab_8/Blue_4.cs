using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_4 : Blue
    {
        private int _output;
        public int Output => _output;
        public Blue_4(string input) : base(input) { _output = 0; }

        private string FindNextNumber(string str, ref int from)
        {
            if (String.IsNullOrEmpty(str) || from < 0 || from > str.Length - 1) return null;

            string number = "";
            //int index = from;
            while (from < str.Length && !Char.IsDigit(str[from])) // ищем первую цифру числа
                from++;
            if (from == str.Length) return null; // после from чисел нет

            if (from != 0 && str[from - 1] == '-') number += '-';
            else number += '+';

            while (from < str.Length && Char.IsDigit(str[from])) // записываем число
            {
                number += str[from];
                from++;
            }

            return number;
        }
        private int Signum(char sgn)
        { 
            switch(sgn)
            {
                case '+': return 1;
                case '-': return -1;
                default: return 0;
            }
        }       
        private double ToInt(string str)
        {
            if(String.IsNullOrEmpty(str)) return double.NaN;

            double number = 0;

            int digitNum = str.Length-1;
            for(int k = 1; k < str.Length; k++)
            {
                int digit = (int)str[k] - (int)'0';
                number += digit * Math.Pow(10,(digitNum - k));
            }
            number *= Signum(str[0]);
            return number;
        }
        private void AddNumber( double number)
        {
            if (number == double.NaN) return;
            _output += (int)number;
        }
        public override void Review()
        {
            if(String.IsNullOrEmpty(Input)) return;

            int index = 0;
            while(index < Input.Length)
            {
                string strNumber = FindNextNumber(Input, ref index);
                if (strNumber == null) return;
                double number = ToInt(strNumber);
                AddNumber(number);
            }
        }

        public string ToString()
        {
            string str = $"{_output}";
            return str;
        }
    }
}

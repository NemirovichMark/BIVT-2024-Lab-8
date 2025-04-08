using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        private string[] _output;
        public string[] Output => _output;
        public Blue_1(string input) : base(input)
        {
            _output = null;
        }

        private void AddToOutput(string str)
        {
            if(_output == null) _output = new string[1];
            else 
                Array.Resize(ref _output, _output.Length + 1);

            _output[_output.Length - 1] = str;
        }
        private string SplitOne(string str)
        {
            if (String.IsNullOrEmpty(str)) return null;
            if (str.Length < 50)
            {
                AddToOutput(str);
                return null;
            }

            // ищем индекс разбития counter
            int counter = 50;
            while (!Char.IsWhiteSpace(str[counter]))
                counter--;
            // сохраняем в res первые counter индексов из str
            char[] resAsArray = new char[counter];
            char[] strAsArray = str.ToCharArray();
            Array.Copy(strAsArray, resAsArray, counter);
            string res = new string(resAsArray);
            // добавляем res в outrut
            AddToOutput(res);
            // удаляем res + пробел из str
            str = str.Remove(0, counter + 1);

            return str;
        }

        public override void Review()
        {
            string tmp = Input;
            while(!String.IsNullOrEmpty(tmp)) 
                tmp = SplitOne(tmp);
        }
        public override string ToString()
        {
            if (_output == null) return null;
            string str = "";
            for(int k = 0; k < _output.Length; k++)
                str += $"{_output[k]}\n";
            str = str.Remove(str.Length - 1, 1);
            return str;
        }
    }
}

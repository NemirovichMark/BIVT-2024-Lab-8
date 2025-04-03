using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2:Purple
    {
        private string[] _output;
        public string[] Output
        {
            get
            {
                if (_output == null) return null;
                var newArray = new string[_output.Length];
                Array.Copy(_output, newArray, _output.Length);
                return newArray;
            }
        }
        public Purple_2(string input) : base(input) { }
        public override string ToString()
        {
            if (_output == null) return null;

            return String.Join("\r\n", _output);
        }
        private static string Formating(string a)
        {
            string formstr = "";
            string[] words = a.Split(' ');
            if (words.Length == 1) return words[0];
            int space = 50 - a.Length;
            int lenspace = space / (words.Length - 1);
            int dopspace = space % (words.Length - 1);
            for (int i = 0;i < words.Length - 1; i++)
            {
                if (i+1 <= dopspace)
                {
                    formstr += words[i];
                    for (int j = 0; j < lenspace + 2; j++) formstr += " ";
                }
                else
                {
                    formstr += words[i];
                    for (int j = 0; j < lenspace+1; j++) formstr += " ";
                }
            }
            formstr += words[words.Length - 1];
            return formstr;

        } 
        public override void Review()
        {
            if (String.IsNullOrEmpty(Input)) return;
            
            int indexspacestart = -1, indexspaceend=-1;
            int lenstr = 0;
            for (int i =0;i < Input.Length; i ++)
            {
                if (i == Input.Length - 1)
                {
                    if (_output == null) _output = new string[0];
                    Array.Resize(ref _output, _output.Length + 1);
                    _output[_output.Length - 1] = Formating(Input.Substring(indexspacestart + 1, i-indexspacestart));
                    indexspacestart = indexspaceend;
                    break;
                }
                lenstr++;
                if (Input[i] == ' ')
                    indexspaceend = i;

                if (lenstr == 50)
                {
                    if (Input[i+1] == ' ')
                    {
                        if (_output == null) _output = new string[0];
                        Array.Resize(ref _output, _output.Length + 1);
                        _output[_output.Length - 1] = Formating(Input.Substring(indexspacestart+1, i-indexspacestart));
                        indexspacestart = i+1;
                        indexspaceend = i + 1;
                        lenstr = -1;
                    }
                    else
                    {
                        if (_output == null) _output = new string[0];
                        Array.Resize(ref _output, _output.Length + 1);
                        
                        _output[_output.Length - 1] = Formating(Input.Substring(indexspacestart + 1, indexspaceend - indexspacestart - 1));
                        indexspacestart = indexspaceend;
                        lenstr = i - indexspaceend ;
                    }
                }
            }
        }
    }

}

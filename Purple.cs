using System;
using System.Linq;


namespace Lab_8
{
    public abstract class Purple
    {
        protected string _input;
        protected string _output;
        public string Input => _input;
        public string Output => _output;

        static protected readonly char[] _enders = { '.', '!', '?' };
        static protected readonly char[] _signs = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        static protected readonly char[] _numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static protected readonly char[] _allsigns = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}',
                                                            '/',' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Purple(string input)
        {
            _input = input;
        }
        protected static bool HasNumber(string s) => s.Any(c => _numbers.Contains(c));
        public abstract void Review();
        public override string ToString()
        {
            return _output;
        }
    }
}

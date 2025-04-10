using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private string _output;
        private (string, char)[] _codes;

        public string Output => _output;

        public Purple_4(string input, (string, char)[] codes) : base(input)
        {
            _codes = codes;
        }

        public override void Review()
        {
            if(Input == null || _codes == null)
            {
                return;
            }
            var result = new StringBuilder(Input);

            foreach(var el in _codes)
            {
                if(el.Item1 == null)
                {
                    continue;
                }
                result.Replace(el.Item2.ToString(), el.Item1);
            }

            _output = result.ToString();
        }

        public override string ToString()
        {
            return _output;
        }
    }
}

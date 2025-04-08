using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private string s = null;
        private string _ans = null;
        private (string, char)[] _codes = null;
        public string Output => _ans;
        public Purple_4(string str, (string, char)[] codes) : base(str)
        {
            s = str;
            _codes = codes;
        }
        public override void Review()
        {
            if (s == null || _codes == null) return;
            foreach (var c in _codes) 
            {
                s = s.Replace(c.Item2.ToString(), c.Item1);
            }
            _ans = s;
        }
        public override string ToString()
        {
            return _ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    abstract public class Purple
    {
        public string Input { get; private set; }

        public Purple(string input)
        {
            Input = input;
        }

        public abstract void Review();
    }
}

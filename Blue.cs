using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Blue
    {
        private readonly string input;
        public string Input => input;

        public string alphabet = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";
        public char[] zhnaki = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/'};
        public Blue(string input)
        {
            this.input = input;
        }

        public abstract void Review();
    }
}

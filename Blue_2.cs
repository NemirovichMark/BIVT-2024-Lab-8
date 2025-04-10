using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_2 : Blue
    {
        private string output;

        private string Output => output;
        private string abc;
        public Blue_2(string input, string abc) : base(input)
        {
            this.abc = abc;
        }

        public override void Review()
        {
            string[] workto = Input.Split(' ');
            string[] res = new string[0];
            for (int i = 0; i < workto.Length; i++)
            {
               // Console.Write(workto[i].ToLower());
               // Console.Write(" ");
               // Console.WriteLine(workto[i].ToLower().IndexOf(abc));
                if (workto[i].ToLower().IndexOf(abc) != -1)
                {
                    Console.WriteLine(workto[i].IndexOf(abc));

                }
                else
                {
                    Array.Resize(ref res, res.Length + 1);
                    res[res.Length - 1] = workto[i];
                }
                
            }
            output = "";
            for (int i = 0; i < res.Length; i++)
            {
                if(i != res.Length-1)
                {
                    output += res[i] + ' ';
                }else
                {
                    output += res[i];
                }
                
            }
            
        }

        public string ToString()
        {
            return output;
        }
    }
}

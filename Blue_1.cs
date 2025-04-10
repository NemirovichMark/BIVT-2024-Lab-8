using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        string[] output;
        public string[] Output
        {
            get
            {
                return output;
            }
        }

        public Blue_1(string input) : base(input)
        {
            output = new string[0];
        }


        public override void Review()
        {

            int n = 0;
            string lastSave = "";
            string curSave = "";
            string[] newRes = new string[0];
            
            for (int i = 0; i < Input.Length; i++)
            {
                Console.WriteLine(Input[i]);
                if (Input[i] == ' ')
                {
                    curSave += ' ';
                    if (curSave.Length < 50)
                    {
                        lastSave = curSave;
                    }
                    else
                    {
                        Array.Resize(ref newRes, newRes.Length + 1);
                        newRes[newRes.Length - 1] = lastSave;
                        curSave = curSave.Substring(lastSave.Length, curSave.Length - lastSave.Length); 
                        lastSave = "";
                    }
                }
                else
                {
                    curSave += Input[i];
                }
                

            }
            
            output = newRes;
            ToString();

        }

        public string ToString()
        {
            string result = "";
            for(int i = 0; i < output.Length; i++)
            {
                if(i == output.Length - 1)
                {
                    result += output[i];
                }
                else
                {
                    result += output[i] + '\n';
                }
                

            }
            return result;
        }
    }
}

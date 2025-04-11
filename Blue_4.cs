using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_4 : Blue
    {
        public int output = 0;
        public int Output => output;
        public Blue_4(string input) : base(input)
        {
        }
        public override string ToString()
        {
            return output.ToString();
        }
        public override void Review()
        {
            if (Input == null) return;
            int sum = 0;
            int currentNumber = 0;
            bool isNegative = false;
            bool inNumber = false;
            int numb = -1;

            string newI = new string(Input.Reverse().ToArray());

            //Console.WriteLine(newI);


            foreach (char c in newI)
            {
                if (c >= '0' && c <= '9')
                {
                    inNumber = true;
                    numb += 1;
                   // Console.WriteLine( Math.Pow(10, numb) *  (c - '0'));
                    currentNumber += (int)(Math.Pow(10, numb) *  (c - '0'));
                    //Console.WriteLine(currentNumber);
                }

                else
                {
                    if (inNumber)
                    {
                        if (isNegative)
                        {
                            currentNumber = -currentNumber;
                        }
                        numb = -1;
                        sum += currentNumber;
                        currentNumber = 0;
                        isNegative = false;
                        inNumber = false;
                    }
                }
            }

            if (inNumber)
            {
                if (isNegative)
                {
                    currentNumber = -currentNumber;
                }
                sum += currentNumber;
            }

            output = sum;
        }
    }
    
}

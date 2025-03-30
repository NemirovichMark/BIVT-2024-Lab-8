using System;
using System.Linq;

namespace Lab_8{
    public class Purple_2 : Purple{
        private string _output;

        public string Output => _output;

        public Purple_2(string input) : base(input) { 
            _output = "";
        }

        public override void Review()
        {
            char[] chars = Input.ToCharArray();
            string ans = "";
            //System.Console.WriteLine('q');
            int l = 0, target = 0;
            while (l < chars.Length){
                int count = 0;
                int r = l;
                while (count < 50 && r < chars.Length){
                    count++;
                    if (chars[r] == ' ' || r == chars.Length - 1){
                        target = r;
                    }
                    if (r+1 < chars.Length && chars[r+1]== ' '){
                        target = r+1;
                    }
                    r++;
                }
                string tmp = "";
                //System.Console.WriteLine($"{l} - {target}");
                for (int i = l; i < target; i++){
                    tmp += chars[i];
                }

                tmp = SpaceBetween(tmp.Trim());
                
                if (target+1 < chars.Length-1){
                    tmp += "\n";
                }
                else{
                    tmp += chars[target];
                }
                ans += tmp; //убираем пробелы по краям
                l = target+1;   
                //System.Console.WriteLine(ans);             
            }
            //System.Console.Write(ans);
            _output = ans;
        }

        private string SpaceBetween(string input){
            int count = 0;
            for (int i = 0; i < input.Length; i++){
                if (input[i] == ' '){
                    count++;
                }
            }
            if (count == 0){
                return input;
            }
            
            int Spaces = 50 - input.Length;
            int deafultSpace = 1 + Spaces / count;
            int extraSpace = Spaces % count; //количество мест в которые будут добавлены "лишние пробелы" которые не делятся поровну

            string result = "";
            int added = 0;
            int Space = deafultSpace;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (added < extraSpace)
                    {
                        Space = deafultSpace + 1;
                    }
                    else
                    {
                        Space = deafultSpace;
                    }
                    
                    result += new string(' ', Space);//char n раз
                    added++;
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }

        public override string ToString() { return _output; }
    }
}
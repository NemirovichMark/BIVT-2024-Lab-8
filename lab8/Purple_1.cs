using System;
using System.Linq;

namespace Lab_8{
    public class Purple_1 : Purple{
        private string _output;

        public string Output => _output;

        public Purple_1(string input) : base(input) { 
            _output = null;
        }

        public override void Review()
        {
            string[] lst = new string[0];
            char[] chars = Input.ToCharArray();
            string ans = "";
            int l = 0, r = 0;
            while (l < chars.Length && r < chars.Length){
                if (!isChar(chars[l]) && !char.IsNumber(chars[l])){
                    r = l;
                }
                else{
                    ans += chars[l];
                    l++;
                    continue;
                }
                
                //System.Console.WriteLine($"{ans} {l} - {chars[l]}, {r} - {chars[r]}");
                while (r < chars.Length && !isChar(chars[r]) && !char.IsNumber(chars[r])){
                    r++;
                }
                //System.Console.WriteLine($"{l}, {r}");
                for (int i = r-1; i >= l; i--){
                    //System.Console.WriteLine(chars[i]);
                    ans += chars[i];
                }
                if (r < chars.Length){
                    ans += chars[r];
                }
                l = r+1;
            }
            //System.Console.WriteLine(ans);
            _output = ans;
        }

        public override string ToString() { return _output; }
    }
}
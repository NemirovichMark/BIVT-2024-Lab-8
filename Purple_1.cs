using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
	public class Purple_1 : Purple
	{
		private string _output;
		public string Output => _output;

		public Purple_1(string input) : base(input) { }

		private void  RevStringBuilder(StringBuilder array, int stindex, int lindex)
		{
			if (stindex < 0 || lindex >= array.Length)
			{
				return;
			}

			while(stindex < lindex)
			{
				(array[stindex], array[lindex]) = (array[lindex], array[stindex]);
				stindex++;
				lindex--;
			}
		}

		public override void Review()
		{
			if (string.IsNullOrEmpty(Input))
			{
				_output = Input;
				return;
			}

			var res = new StringBuilder(Input);
			int st = -1;
			bool prepnext = false;
			for(int i = 0; i < Input.Length; ++i)
			{
				bool letter = InWord(Input[i]);
				prepnext = IsPunct(Input[i]) || (letter && i == Input.Length - 1);
				if(letter && st == -1 &&((i > 0 && IsPunct(Input[i-1])) || i == 0))
				{
					st = i;
				}

				if(prepnext  && st > -1)
				{
					if (letter)
					{
						RevStringBuilder(res, st, i);
					}
					else
					{
						RevStringBuilder(res, st, i - 1);
					}
					st = -1;
				}
			}
			_output = res.ToString();
		}

        public override string ToString()
        {
			return _output;
        }

    }
}

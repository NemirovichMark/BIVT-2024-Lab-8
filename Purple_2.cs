﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lab_8
{
	public class Purple_2: Purple
	{
		private string[] _output;
		public string[] Output
		{
			get
			{
				var newarr = new string[_output.Length];
				Array.Copy(_output, newarr, _output.Length);
				return newarr;
			}
		}

		public Purple_2(string input): base(input){}

		public override void Review()
		{
			if(Input  == null)
			{
				return;
			}

			string[] splitted = Input.Trim().Replace('\n', ' ').Split();
			var result = new StringBuilder();
			var current = new StringBuilder();

			for(int i = 0; i < splitted.Length; ++i)
			{
				var word = splitted[i];
				if(word.Length == 0)
				{
					continue;
				}


				int n = current.Length;
				if ((n + word.Length + 1 <= 50) || (n == 0 && word.Length <= 50))
				{
					if (n > 0)
					{
						current.Append(' ');
					}
					current.Append(word);
				}

				if( n+ word.Length + 1 > 50 || i == splitted.Length - 1)
				{
					if(result.Length > 0)
					{
						result.Append('\n');
					}
					var cursplit = current.ToString().Split();
					int spaces = cursplit.Length - 1;
					int remain = 50 - current.Length;
					if(remain < 0)
					{
						remain = 0;
					}
					int minsp, additionalspaces;
					if(spaces > 0)
					{
						minsp = 1 + remain / spaces;
						additionalspaces = remain % spaces;
					}
					else
					{
						minsp = remain;
						additionalspaces = 0;
					}
					
					for(int j = 0; j < spaces; ++j)
					{
						result.Append(cursplit[j]);
						int curspaces = minsp;
						if(j < additionalspaces)
						{
							curspaces++;
						}
						result.Append(new string(' ', curspaces));
					}
					result.Append(cursplit[cursplit.Length - 1]);
					if(spaces == 0)
					{
                        result.Append(new string(' ', remain));
                    }

					current.Clear();
					current.Append(word);

					if (n + word.Length + 1 > 50 && i == cursplit.Length - 1)
					{
						result.Append("\n" + current);
					}

				}
			}
			_output = result.ToString().Split('\n');
		}

        public override string ToString()
        {
            if(_output == null) { return null; }
			return String.Join('\n', _output);
        }


    }
}

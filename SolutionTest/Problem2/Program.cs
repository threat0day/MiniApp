using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Проверить сбалансированность скобочной структуры 
 * в произвольном выражении ((1+3)()(4+(3-5))) 
 */
namespace Problem2
{
	public class Program
	{
		static void Main(string[] args)
		{

		}

		public bool CheckBalanceBracket(string s)
		{
			int countBracket=0;

			foreach (var item in s)
			{
				if (item.ToString().Equals("("))
					countBracket++;

				if (item.ToString().Equals(")"))
					countBracket--;

				if (countBracket < 0)
					return false;
			}
			return countBracket==0?true:false;
		}
	}
}

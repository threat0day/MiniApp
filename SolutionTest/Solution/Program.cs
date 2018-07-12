using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Написать функцию, которая преобразует строку с
 * римским числом в целое 
 * (иными словами, написать тело функции public int RomanToInt(string s)). 
 * Римское число не больше 3000. 
 */

namespace Solution
{

	public class Program
	{

		static void Main(string[] args)
		{

		}
		public int RomanToInt(string s)
		{
			if (s.Length==0)
				return 0;

			var romanNums = new Dictionary<string, int>()
			{
				{"I",1 },
				{"V",5 },
				{"X",10 },
				{"L",50 },
				{"C",100 },
				{"D",500 },
				{"M",1000 }
			};

			int result = 0;

			Func<string, int> GetValue = (str) =>
			   {
				   if (romanNums.ContainsKey(str))
				   {
					   return romanNums[str];
				   }
				   else
					   throw new Exception("Не корректное число");
			   };

			int prev = romanNums[s[0].ToString()];

			for (int i = 1; i < s.Length; i++)
			{
				int next = romanNums[s[i].ToString()];

				if (prev < next)
				{
					result -= prev;
				}
				else
				{
					result += prev;
				}

				prev = next;
			}
			result += prev;

			return result;
		}
	}
}

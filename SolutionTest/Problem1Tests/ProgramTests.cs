using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void RomanToIntTest()
		{
			var main = new Program();
			Assert.AreEqual(main.RomanToInt("I"), 1);
			Assert.AreEqual(main.RomanToInt("IV"), 4);
			Assert.AreEqual(main.RomanToInt("MMCMXCIX"), 2999);
			Assert.AreEqual(main.RomanToInt("MMM"), 3000);
		}
	}
}
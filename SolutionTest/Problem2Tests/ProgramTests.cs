using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void CheckBalanceBracketTest()
		{
			var main=new Program();
			Assert.AreEqual(main.CheckBalanceBracket("()"),true);
			Assert.AreEqual(main.CheckBalanceBracket(")("), false);
			Assert.AreEqual(main.CheckBalanceBracket("((()))"), true);
			Assert.AreEqual(main.CheckBalanceBracket("900((00))99(("), false);
		}
	}
}
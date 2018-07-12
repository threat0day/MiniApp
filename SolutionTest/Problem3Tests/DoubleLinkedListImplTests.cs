using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.Tests
{
	[TestClass()]
	public class DoubleLinkedListImplTests
	{
		[TestMethod()]
		public void AddFirstTest()
		{
			var list = new DoubleLinkedListImpl<int>();

			list.AddFirst(1);
			Assert.AreEqual(list.FirstOrDefault(), 1);
			Assert.IsNotNull(list.First);
		}

		[TestMethod()]
		public void AddLastTest()
		{
			var list = new DoubleLinkedListImpl<int>() ;
			list.AddLast(1);
			Assert.AreEqual(list.FirstOrDefault(), 1);
			Assert.IsNotNull(list.First);

		}

		[TestMethod()]
		public void ReverseTest()
		{
			var list = new DoubleLinkedListImpl<int>();
			list.AddLast(1);
			list.AddLast(2);
			list.AddLast(3);
			string s = "";
			foreach (var item in list)
				s +=$" {item.ToString()}";
			Assert.AreEqual(s, " 1 2 3");
			list.Reverse();

			s = "";
			foreach (var item in list)
				s += $" {item.ToString()}";
			Assert.AreEqual(s, " 3 2 1");

		}

	}
}